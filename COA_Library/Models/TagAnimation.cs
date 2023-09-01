// Local
using COA_Library.Base;
using COA_Library.Enums;

namespace COA_Library.Models
{
    public class TagAnimation : TagBase
    {
        public AnimationBase? AnimationBase { get; set; }
        public AnimationKeyFrames? TypeName { get; set; }
        public virtual string ToTag(string values)
        {
            return string.Format("{0}\n{1}\n{2}", TagOpen, values, TagClose);
        }

        public override string ToTag()
        {
            return string.Format("{0}{1}", TagOpen, TagClose);
        }
    }
}
