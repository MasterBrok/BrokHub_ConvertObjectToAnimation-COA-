

using System;
using System.Windows.Input;

namespace BrokHub_ConverObjectToAnimation.MVVM.ViewModels
{
    public partial class HomeViewModel
    {
        private ICommand _open;

        public ICommand Opne
        {
            get
            {
                base.FillCommand(ref _open,Open_Click,CanOpen_Clicl);
                return _open;
            }
        }
     
    }
}
