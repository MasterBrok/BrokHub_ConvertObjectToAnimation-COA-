// Local
using BrokHub_ConverObjectToAnimation.MVVM.Views;


namespace BrokHub_ConverObjectToAnimation.MVVM.ViewModels
{
    public partial class ErrorViewModel : Base.Notify
    {

        #region Private Property
        private string _title;
        private string _message;

        #endregion

        #region Public Porperty
        public string ErrorTitle
        {
            get { return _title; }
            set
            {
                _title = value;
                base.NoifyEvent(nameof(ErrorTitle));
            }
        }



        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                base.NoifyEvent(nameof(Message));
            }
        }

        #endregion

        #region CTOR
        public ErrorViewModel()
        {


        }

        public ErrorViewModel(string titel, string message)
        {
            _title = titel;
            _message = message;

        }

        #endregion


        #region Private Function

        private bool CanOk_Click(object obj)
        {
            return true;
        }

        private void OK_Click(object obj)
        {
            (obj as ErrorView).Close();
        }
        #endregion
    }
}
