
//System
using System;

namespace COA_Library.IBrok
{
    public interface IKeyFrame
    {
        TimeSpan? Time { get; set; }
        object? Value { get; set; }
        object? FromValue { get; set; }
    }
}
