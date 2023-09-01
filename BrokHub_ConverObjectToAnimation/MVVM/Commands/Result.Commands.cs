using System.Windows.Input;

namespace BrokHub_ConverObjectToAnimation.MVVM.ViewModels
{
    public partial class ResultViewModel
    {
        private ICommand _copy;
        /// <summary>
        /// Copy Tags
        /// </summary>
        public ICommand Copy
        {
            get
            {
                base.FillCommand(ref _copy,CopyTags_Click, CanCopyTags_Click);
                return _copy;
            }
        }
    }
}
