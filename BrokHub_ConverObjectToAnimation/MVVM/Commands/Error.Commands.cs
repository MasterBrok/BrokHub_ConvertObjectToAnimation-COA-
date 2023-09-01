
using System.Windows.Input;

namespace BrokHub_ConverObjectToAnimation.MVVM.ViewModels
{
    public partial class ErrorViewModel : Base.Notify
    {
        private ICommand _ok;
        /// <summary>
        /// Close Window
        /// </summary>
        public ICommand OK
        {
            get
            {
                base.FillCommand(ref _ok,OK_Click,CanOk_Click);
                return _ok;
            }
        }

       
    }
}
