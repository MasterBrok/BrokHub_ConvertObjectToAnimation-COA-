

using System;

namespace COA_Library.Models.Frame
{
   public class DiscreteAnimation : IBrok.IKeyFrame
    {
        public TimeSpan? Time { get; set; }
        public object? FromValue { get; set; }
        public object? Value { get; set; }
        public DiscreteAnimation(TimeSpan? time, object? fromValue, object? toValue)
        {
            Time = time;
            FromValue = fromValue;
            Value = toValue;
        }
        public DiscreteAnimation()
        {

        }
    }
}
