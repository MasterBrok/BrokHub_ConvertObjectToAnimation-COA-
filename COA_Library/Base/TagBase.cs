
namespace COA_Library.Base
{
    public abstract class TagBase
    {
        public string? TagOpen { get; set; }
        public string? TagClose { get; set; }
        public static string? Open { get => "<"; }
        public static string? Close { get => ">"; }
        public static string? Back { get => "/"; }
        public static string? BackClose { get => "/>"; }
        public abstract string ToTag();
    }
}
