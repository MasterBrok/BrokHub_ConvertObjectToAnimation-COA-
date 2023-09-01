// Local
using BrokHub_ConverObjectToAnimation.BaseControls.CheckBoxs;
using BrokHub_ConverObjectToAnimation.MVVM.Base;

// Sysytem
using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;

// DLL
using COA_Library.Build;
using COA_Library.Enums;
using COA_Library.IBrok;
using COA_Library.Models;
using COA_Library.Models.Frame;
using BrokHub_ConverObjectToAnimation.MVVM.Convertors;

namespace BrokHub_ConverObjectToAnimation.MVVM.ViewModels
{
    public partial class COAViewModel : Notify
    {
        #region Readonly Property
        private readonly string DA = "DiscreteAnimation";
        private readonly string LA = "LinearAnimation";
        private readonly string SA = "SplineAnimation";
        #endregion


        #region Private Property

        private List<IKeyFrame> frame = new List<IKeyFrame>();
        private IKeyFrame _frame;
        private string _type;
        private TagAnimation? _tagAnimation;
        private string _temp = "";
        private TimeSpan _time;
        private bool isShow = false;

        #endregion


        #region Public Property
        public IKeyFrame Frame
        {
            get { return _frame; }
            set
            {
                _frame = value;
                NoifyEvent(nameof(Frame));
            }
        }

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                base.NoifyEvent(nameof(Type));
            }
        }

        public TagAnimation? TagAnimation
        {
            get { return _tagAnimation; }
            set
            {
                _tagAnimation = value;
                NoifyEvent(nameof(TagAnimation));
            }
        }

        public string Temp
        {
            get { return _temp; }
            set
            {
                _temp = value;
                base.NoifyEvent(nameof(Temp));
            }
        }


        public ccCheckBox? cc { get; set; } = new ccCheckBox();


        public TimeSpan JumpTime
        {
            get { return _time; }
            set
            {
                _time = value;
                base.NoifyEvent(nameof(JumpTime));
            }
        }
        #endregion


        #region Spline Property
        private double? _x1;
        public double? X1
        {
            get { return _x1; }
            set { _x1 = value; base.NoifyEvent(nameof(X1)); }
        }


        private double? _x2;
        public double? X2
        {
            get { return _x2; }
            set { _x2 = value; base.NoifyEvent(nameof(X1)); }
        }


        private double? _x3;
        public double? X3
        {
            get { return _x3; }
            set { _x3 = value; base.NoifyEvent(nameof(X1)); }
        }


        private double? _x4;
        public double? X4
        {
            get { return _x4; }
            set { _x4 = value; base.NoifyEvent(nameof(X1)); }
        }
        #endregion



        #region Private Function Commands
        private bool CanBuildFrame_Click(object obj)
        {
            return true;
        }


        private bool CanClose_Click(object obj)
        {
            return true;
        }

        private void Close_Click(object obj)
        {
            Application.Current.Shutdown();
        }

        private void BuildFrame_Click(object obj)
        {
            try
            {
                cc = obj as ccCheckBox;
                ResultViewModel model = new ResultViewModel();
                model.view = new Views.ResultView();
                switch (cc?.Tag)
                {
                    case "D":
                        model.Result = Building(nameof(DiscreteAnimation));
                        break;
                    case "L":
                        model.Result = Building(nameof(LinearAnimation));

                        break;
                    case "S":
                        model.Result = Building(nameof(SplineAnimation));

                        break;

                    default:
                        break;
                }



                AnimationBuilder builder = new AnimationBuilder(new TagAnimation()
                {
                    AnimationBase = TagAnimation?.AnimationBase
                });
                string tag = builder.AnimationUsingKeyFrameBuilding(ConvertTypeToUsingAnimation.Convert(Type)).ToTag(model.Result);

                if (!string.IsNullOrEmpty(model.Result) && !string.IsNullOrEmpty(tag))
                {
                    model.view.lblReult.Text = tag;
                    model.view.ShowDialog();
                }

                frame.Clear();

            }
            catch (Exception e)
            {
                ErrorViewModel viewError = new ErrorViewModel("Error", e.Message);
                Views.ErrorView error = new Views.ErrorView()
                {
                    DataContext = viewError
                };
            }
        }

        #endregion


        #region Private Function 

        private string Building(string type)
        {
            try
            {
                _temp = "";
                TagBuilder? tb = new TagBuilder(Frame, Type);
                List<IKeyFrame> IK = new();
                tb.JumpTime = JumpTime;


                if (type == this.DA)
                {
                    tb._dls = DLS.Discrete;
                    if (_type == "String")
                    {
                        IK = ToFrameString<DiscreteAnimation>(Frame.Value?.ToString().Trim().ToCharArray());


                        //MessageBox.Show(_temp);
                    }

                    else if (_type == "Color")
                    {
                        IK = ToFrameColor<DiscreteAnimation>(Frame.Value.ToString().Trim().Split(','));

                        //MessageBox.Show(_temp);
                    }

                    else if (_type == "Double")
                    {
                        IK = ToFrameDouble<DiscreteAnimation>(
                            start: double.Parse(Frame.Value.ToString().Trim().Split(',')[0]),
                            double.Parse(Frame.Value.ToString().Split(',')[1]));

                        //MessageBox.Show(_temp);
                    }

                }


                else if (type == this.LA)
                {

                    tb._dls = DLS.Linear;

                    if (_type == "Color")
                    {
                        IK = ToFrameColor<LinearAnimation>(Frame.Value.ToString().Trim().Split(','));

                        //MessageBox.Show(_temp);
                    }

                    else if (_type == "Double")
                    {
                        IK = ToFrameDouble<LinearAnimation>
                            (
                            start: double.Parse(Frame.Value.ToString().Trim().Split(',')[0]),
                            double.Parse(Frame.Value.ToString().Trim().Split(',')[1])
                            );

                        //MessageBox.Show(_temp);
                    }
                    else
                        _temp = "DLS != Frame Animation";

                }

                else
                    _temp = String.Empty;

                foreach (var item in tb.BuildDLS(IK))
                    _temp += item.ToTag() + "\n";


                return _temp;
            }
            catch (Exception e)
            {
                ErrorViewModel viewError = new ErrorViewModel("Error", e.Message);
                Views.ErrorView error = new Views.ErrorView()
                {
                    DataContext = viewError
                };
                error.Show();
                return _temp = String.Empty;
            }
        }
        private List<IKeyFrame> ToFrameString<T>(char[]? values)
        {
            try
            {
                values.ToList().RemoveAll(e => e is '\n' || e is '\r');
                string temp = "";

                for (int start = 0; start < values?.Length; start++)
                {
                    temp += values[start].ToString();
                    if (typeof(T) == typeof(DiscreteAnimation))
                        frame.Add(new DiscreteAnimation(_frame.Time, null, temp));
                    else if (typeof(T) == typeof(LinearAnimation))
                        frame.Add(new LinearAnimation(_frame.Time, null, temp));
                    //else if (typeof(T) == typeof(SplineAnimation))
                    //frame.Add(new SplineAnimation(_frame.Time, null, temp));

                }
                return frame;
            }
            catch (Exception e)
            {
                ErrorViewModel viewError = new ErrorViewModel("Error", e.Message);

                Views.ErrorView error = new Views.ErrorView()
                {
                    DataContext = viewError
                };
                error.ShowDialog();
                return new List<IKeyFrame>();
            }
        }

        private List<IKeyFrame> ToFrameDouble<T>(double start = 0, double end = 2)
        {
            try
            {
                for (double number = start; number <= end; number++)
                {
                    if (typeof(T) == typeof(DiscreteAnimation))
                        frame.Add(new DiscreteAnimation(_frame.Time, null, number));
                    else if (typeof(T) == typeof(LinearAnimation))
                        frame.Add(new LinearAnimation(_frame.Time, number, null));
                    //else if (typeof(T) == typeof(SplineAnimation))
                    //frame.Add(new SplineAnimation(_frame.Time, null, temp));
                }
                return frame;
            }
            catch (Exception e)
            {
                ErrorViewModel viewError = new ErrorViewModel("Error", e.Message);

                Views.ErrorView error = new Views.ErrorView()
                {
                    DataContext = viewError
                };
                error.ShowDialog();
                return new List<IKeyFrame>();
            }
        }

        private List<IKeyFrame> ToFrameColor<T>(string[] colorNames)
        {
            try
            {
                for (int number = 0; number < colorNames.Length; number++)
                {
                    if (typeof(T) == typeof(DiscreteAnimation))
                        frame.Add(new DiscreteAnimation(_frame.Time, null, colorNames[number]));

                    else if (typeof(T) == typeof(LinearAnimation))
                        frame.Add(new LinearAnimation(_frame.Time, colorNames[number], null));
                    //else if (typeof(T) == typeof(SplineAnimation))
                    //frame.Add(new SplineAnimation(_frame.Time, null, temp));
                }
                return frame;
            }
            catch (Exception e)
            {
                ErrorViewModel viewError = new ErrorViewModel("Error", e.Message);

                Views.ErrorView error = new Views.ErrorView()
                {
                    DataContext = viewError
                };
                error.ShowDialog();
                return new List<IKeyFrame>();

            }
        }

        #endregion



        public COAViewModel()
        {

            Frame = new LinearAnimation()
            {
                Time = new TimeSpan(0, 0, 0, 0),
            };

            TagAnimation = new()
            {
                AnimationBase = new()
                {
                    BeginTime = new TimeSpan(0, 0, 0, 0),
                    Duration = new Duration(new TimeSpan(0, 0, 0, 0)),
                },
            };
            _time = new TimeSpan(0, 0, 0, 0);
        }
    }
}
