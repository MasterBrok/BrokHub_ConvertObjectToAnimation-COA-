
using COA_Library.Enums;

namespace BrokHub_ConverObjectToAnimation.MVVM.Convertors
{
    public static class ConvertTypeToUsingAnimation
    {
        /// <summary>
        /// Return Enums
        /// </summary>
        /// <param name="type">start with Enum</param>
        /// <returns></returns>
        public static AnimationKeyFrames Convert(string type)
        {
            if (type.Trim().StartsWith("String"))
                return AnimationKeyFrames.StringAnimationUsingKeyFrames;
            else if (type.Trim().StartsWith("Double"))
                return AnimationKeyFrames.DoubleAnimationUsingKeyFrames;

            else if (type.Trim().StartsWith("Color"))
                return AnimationKeyFrames.ColorAnimationUsingKeyFrames;
            
            return AnimationKeyFrames.NotFoundUsingKeyFrames;
        }
    }
}
