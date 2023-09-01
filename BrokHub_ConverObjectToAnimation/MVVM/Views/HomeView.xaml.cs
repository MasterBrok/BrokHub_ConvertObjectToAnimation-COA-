using COA_Library.Base;
using COA_Library.Build;
using COA_Library.IBrok;
using COA_Library.Models;
using COA_Library.Models.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace BrokHub_ConverObjectToAnimation.MVVM.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        public HomeView()
        {
            InitializeComponent();

            //IKeyFrame<double> color = new LinearAnimation<double>();
            //color.ToValue = 120;
            //color.FromValue = 0;


            //AnimationBuilder animation = new AnimationBuilder();
            //TagAnimation t = animation.AnimationUsingKeyFrameBuilding(COA_Library.Enums.AnimationKeyFrames.StringAnimationUsingKeyFrames);
            //animation.AutoReverse = true;
            //animation.IsAdditive = true;
            //animation.Storyboard = new BrokStoryboard() { TargetProperty = "Color" };

            //MessageBox.Show(t.ToTag());


            //TagBuilder<double> tag = new TagBuilder<double>(color);
            //tag.BuildDLS(new List<IKeyFrame<double>>()
            //{
            //    new LinearAnimation<double>(new TimeSpan(0,0,0,1),1,2),
            //    new SplineAnimation<double>(new TimeSpan(0,0,0,2),2,3,1,1,1,1),
            //    new DiscreteAnimation<double>(new TimeSpan(0,0,0,3),3,4),
            //}
            //).ToList().ForEach(e =>
            //{
            //    MessageBox.Show(e.ToTag());
            //});

            //AnimationBuilder build = new();
            //build.FillBehavior = COA_Library.Enums.FillBehavior.Stop;
            //build.Duration = new Duration(new TimeSpan(1,1,1,1));
            //MessageBox.Show(build.AnimationUsingKeyFrameBuilding(COA_Library.Enums.AnimationKeyFrames.DoubleAnimationUsingKeyFrames).ToTag());

        }
    }
}
