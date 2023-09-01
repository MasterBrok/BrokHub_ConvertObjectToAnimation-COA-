
using System;

namespace COA_Library.Models.Frame
{
    public class SplineAnimation : IBrok.IKeyFrame
    {
        public TimeSpan? Time { get; set; }
        public object? Value { get; set; }
        public object? FromValue { get; set; }
        public double? X1 { get; set; }
        public double? X2 { get; set; }
        public double? X3 { get; set; }
        public double? X4 { get; set; }
        public SplineAnimation()
        {

        }
        public SplineAnimation(double? x1, double? x2, double? x3, double? x4)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
            X4 = x4;
        }
        public SplineAnimation(TimeSpan? time, object? toValue, object? fromValue, double? x1, double? x2, double? x3, double? x4)
        {
            Time = time;
            Value = toValue;
            FromValue = fromValue;
            X1 = x1;
            X2 = x2;
            X3 = x3;
            X4 = x4;
        }
    }
}
