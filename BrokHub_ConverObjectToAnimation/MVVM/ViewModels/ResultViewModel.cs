
// Local
using BrokHub_ConverObjectToAnimation.BaseControls.TextBoxs;
using BrokHub_ConverObjectToAnimation.MVVM.Views;
// System
using System.Windows;

namespace BrokHub_ConverObjectToAnimation.MVVM.ViewModels
{
    public partial class ResultViewModel : Base.Notify
    {


        #region Private Property
        public ResultView view;
        private bool _isCopy = false;
        private string _animation = "Null";

        #endregion

        #region Public Property

        public bool IsCopy
        {
            get { return _isCopy; }
            set
            {
                _isCopy = value;
                base.NoifyEvent(nameof(IsCopy));
            }
        }




        public string Result
        {
            get { return _animation; }
            set
            {
                _animation = value;
                base.NoifyEvent(nameof(Result));
            }
        }

        #endregion


        #region Private Function

        private bool CanCopyTags_Click(object obj)
        {
            return true;
        }

        private void CopyTags_Click(object obj)
        {

            Clipboard.SetText((obj as ccTextBoxCOA).Text);
            IsCopy = true;
        }

        #endregion

        public ResultViewModel()
        {

        }

    }
}
