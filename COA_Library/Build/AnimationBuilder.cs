// Local
using COA_Library.Enums;
using COA_Library.Models;
//System
using System;

namespace COA_Library.Build
{
    public class AnimationBuilder
    {
        private TagAnimation tag;
        public AnimationBuilder(TagAnimation Tag)
        {
            tag = Tag;
        }
        /// <summary>
        ///  Create Animations
        /// </summary>
        /// <param name="keyFrame">Color Or Double Orr String</param>
        /// <returns>Tags</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public TagAnimation AnimationUsingKeyFrameBuilding(AnimationKeyFrames keyFrame)
        {
            try
            {
                tag.TypeName = keyFrame;
                tag.TagOpen = String.Format("{0}{1} {2}=\"{3}\" {4}=\"{5}\" {6}=\"{7}\" {8}=\"{9}\" {10}=\"{11}\" {12}=\"{13}\" " +
                    "{14}=\"{15}\" {16}=\"{17}\" {18}=\"{19}\" {20}=\"{21}\" {22}=\"{23}\" {24}=\"{25}\"  {26}=\"{27}\" {28}",
                      TagDLS.Open, tag.TypeName,
                      "x:Key", tag.AnimationBase?.KeyName
                    , nameof(TagAnimation.AnimationBase.IsAdditive), tag.AnimationBase?.IsAdditive
                    , nameof(TagAnimation.AnimationBase.IsCumulative), tag.AnimationBase?.IsCumulative
                    , nameof(TagAnimation.AnimationBase.AutoReverse), tag.AnimationBase?.AutoReverse
                    , nameof(TagAnimation.AnimationBase.AccelerationRatio), tag.AnimationBase?.AccelerationRatio
                    , nameof(TagAnimation.AnimationBase.DecelerationRatio), tag.AnimationBase?.DecelerationRatio
                    , nameof(TagAnimation.AnimationBase.SpeedRatio), tag.AnimationBase?.SpeedRatio
                    , "FillBehavior", tag.AnimationBase?.FillBehavior
                    , nameof(TagAnimation.AnimationBase.Duration), tag.AnimationBase?.Duration
                    , nameof(TagAnimation.AnimationBase.BeginTime), tag.AnimationBase?.BeginTime
                    , "Storyboard." + nameof(TagAnimation.AnimationBase.Storyboard.TargetName), tag.AnimationBase?.Storyboard.TargetName
                    , "Storyboard." + nameof(TagAnimation.AnimationBase.Storyboard.TargetProperty), tag.AnimationBase?.Storyboard.TargetProperty,
                      nameof(TagAnimation.AnimationBase.RepeatBehavior), tag.AnimationBase?.RepeatBehavior
                      , TagDLS.Close);
                tag.TagClose = String.Format("{0}{1}{2}{3}", TagDLS.Open, TagDLS.Back, tag.TypeName, TagDLS.Close);
                return tag;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Tag DLS Is Null");
            }
        }
    }
}
