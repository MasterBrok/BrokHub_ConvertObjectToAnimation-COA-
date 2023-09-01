// Local
using COA_Library.Base;
using COA_Library.Enums;

namespace COA_Library.Models
{
    /// <summary>
    /// D = Discerte , L = Linear , S =Spline
    /// </summary>
    public class TagDLS : TagBase
    {
        public DLS? DLS { get; set; }
        public override string ToTag()
        {
            return string.Format("{0}{1}", TagOpen, TagClose);
        }
    }
}
