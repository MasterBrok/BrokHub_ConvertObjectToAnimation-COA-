// Local
using COA_Library.Enums;
//System
using System;
using System.Windows;

namespace COA_Library.Models
{
    public class AnimationBase
    {
        public readonly string KeyName = "BrokHub_Animation";
        public string RepeatBehavior { get; set; } = "Forever";
        public BrokStoryboard Storyboard { get; set; } = new() { TargetProperty = "Brok", TargetName = "Brok" };
        public bool IsAdditive { get; set; }
        public bool IsCumulative { get; set; }
        public bool AutoReverse { get; set; }
        public double AccelerationRatio { get; set; }
        public double DecelerationRatio { get; set; }
        public double SpeedRatio { get; set; }
        public FillBehavior FillBehavior { get; set; }
        public Duration Duration { get; set; }
        public TimeSpan? BeginTime { get; set; }
        public AnimationBase()
        {

        }

        //public AnimationBase(FillBehavior fillBehavior, Duration duration, TimeSpan? beginTime,
        //    BrokStoryboard storyboard, string name, bool isAdditive, bool isCumalative,
        //    bool autoReverse, double accelerationRatio, double decelerationRatio, double speedRatio)
        //{
        //    FillBehavior = fillBehavior;
        //    Duration = duration;
        //    BeginTime = beginTime;
        //    Storyboard = storyboard;
        //    KeyName = name;
        //    IsAdditive = isAdditive;
        //    IsCumalative = isCumalative;
        //    AutoReverse = autoReverse;
        //    AccelerationRatio = accelerationRatio;
        //    DecelerationRatio = decelerationRatio;
        //    SpeedRatio = speedRatio;
        //}

        // public abstract TagAnimation AnimationUsingKeyFrameBuilding(AnimationKeyFrames keyFrame);

    }
}
