using System.Windows.Input;

namespace BrokHub_ConverObjectToAnimation.MVVM.ViewModels
{
    public partial class COAViewModel
    {
        private ICommand _buildFrame;
        /// <summary>
        ///  Create tags
        /// </summary>
        public ICommand BuildFrame
        {
            get
            {
                base.FillCommand(ref _buildFrame, BuildFrame_Click, CanBuildFrame_Click);
                return _buildFrame;
            }
        }

        private ICommand _close;
        /// <summary>
        ///  Exite in App
        /// </summary>
        public ICommand Exit
        {
            get
            {
                base.FillCommand(ref _close, Close_Click, CanClose_Click);
                return _close;
            }
        }
    }
}
