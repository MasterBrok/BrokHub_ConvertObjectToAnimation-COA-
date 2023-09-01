
using System;

namespace COA_Library.Models.Frame
{
    public class LinearAnimation : IBrok.IKeyFrame
    {
        public TimeSpan? Time { get; set; }
        public object? Value { get; set; }
        public object? FromValue { get; set; }
       
        public LinearAnimation()
        {

        }
        public LinearAnimation(TimeSpan? time, object? toValue, object? fromValue)
        {
            Time = time;
            Value = toValue;
            FromValue = fromValue;
        }
    }
}
