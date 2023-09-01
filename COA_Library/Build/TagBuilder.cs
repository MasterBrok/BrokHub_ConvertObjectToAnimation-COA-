
//Local
using COA_Library.Enums;
using COA_Library.Models;
using COA_Library.Models.Frame;
//Sysytem
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace COA_Library.Build
{
    public class TagBuilder
    {

        #region Private Property
        private ObservableCollection<TagDLS> _tags;
        private IBrok.IKeyFrame _type { get; set; }

        #endregion

        #region Public Property
        public string TB { get; set; }

        public DLS _dls;
        public TimeSpan? JumpTime { get; set; }
        public TimeSpan? AutoJumpTime;
        #endregion

        #region CTOR
        public TagBuilder()
        {
        }

        public TagBuilder(IBrok.IKeyFrame type, string typeOut)
        {
            _type = type;
            TB = typeOut;
            _tags = new ObservableCollection<TagDLS>();
        }
        #endregion

        #region Public Function
        /// <summary>
        /// Create DLS , Discrete , Spline , Linear
        /// </summary>
        /// <param name="frames">DLS</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public ObservableCollection<TagDLS> BuildDLS(List<IBrok.IKeyFrame> frames)
        {
            try
            {
                AutoJumpTime = frames[0].Time;
                for (int f = 0; f < frames.Count; f++)
                {
                    TagDLS tag = new TagDLS()
                    {
                        DLS = _dls,
                    };
                    AutoJumpTime += JumpTime;

                    tag.TagOpen = CreateTagOpen(frames[f]);
                    tag.TagClose = String.Format("{0}{1}{2}{3}", TagDLS.Open, TagDLS.Back, NameTag(frames[f].GetType()) + FrameName(), TagDLS.Close);

                    _tags.Add(tag);
                }
                return _tags;
            }
            catch (Exception e)
            {
                throw new Exception(String.Format("Inputs Is Not Valid \n{0}", e.Message));
            }
        }

        /// <summary>
        /// Convert ToTag
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public string ToTag()
        {
            try
            {
                return String.Format("{0} {1}", _type.FromValue, _type.Value);
            }
            catch (Exception)
            {
                throw new ArgumentNullException("From And To Is Invaid Or Null");
            }
        }

        #endregion

        #region Internal Function
        /// <summary>
        /// Create tag Opem 
        /// </summary>
        /// <param name="frame"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal string CreateTagOpen(IBrok.IKeyFrame frame)
        {
            try
            {

                if (frame is SplineAnimation spline)
                {
                    return String.Format("{0}{1} {2} = \"{3}\" {4} = \"{5}\" {6} = \"{7}\" {8}", TagDLS.Open, NameTag(frame.GetType()) + FrameName(), nameof(IBrok.IKeyFrame.Value), frame.Value, "Key" + nameof(IBrok.IKeyFrame.Time), frame.Time, "KeySpline", (spline.X1 + " " + spline.X2 + " " + spline.X3 + " " + spline.X4), TagDLS.Close);
                }

                return String.Format("{0}{1} {2} = \"{3}\" {4} = \"{5}\" {6}", TagDLS.Open, NameTag(frame.GetType()) + FrameName(), nameof(IBrok.IKeyFrame.Value), frame.Value, "Key" + nameof(IBrok.IKeyFrame.Time), AutoJumpTime, TagDLS.Close);
            }
            catch (Exception)
            {

                throw new Exception("Create Tag Open Is Failed");
            }
        }
        /// <summary>
        /// Find Name Tag
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal string NameTag(Type type)
        {
            try
            {
                if (type.Name == "DiscreteAnimation")
                    return DLS.Discrete.ToString();

                else if (type.Name == "LinearAnimation")
                    return DLS.Linear.ToString();

                else if (type.Name == "SplineAnimation")
                    return DLS.Spline.ToString();

                return DLS.Discrete.ToString();
            }
            catch (Exception)
            {
                throw new Exception("DLS Is Not Valid");
            }
        }
        /// <summary>
        /// Find Frame tag
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal string FrameName()
        {
            try
            {
                if (TB is "Double")
                    return Key.DoubleKeyFrame.ToString();

                else if (TB is "String")
                    return Key.StringKeyFrame.ToString();

                else if (TB is "Color")
                    return Key.ColorKeyFrame.ToString();

                return Key.StringKeyFrame.ToString();
            }
            catch (Exception)
            {
                throw new Exception("Frame Is Not Valid");
            }
        }
        #endregion
    }
}
