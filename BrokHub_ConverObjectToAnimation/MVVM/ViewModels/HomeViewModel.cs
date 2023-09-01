// Local
using BrokHub_ConverObjectToAnimation.MVVM.Base;
using BrokHub_ConverObjectToAnimation.MVVM.Views;
//System
using System;

namespace BrokHub_ConverObjectToAnimation.MVVM.ViewModels
{
    public partial class HomeViewModel : Notify
    {
        public HomeViewModel()
        {

        }
        private void Open_Click(object obj)
        {
            (obj as HomeView).Hide();
            COAView view = new COAView();
            view.ShowDialog();
        }

        private bool CanOpen_Clicl(object obj)
        {
            return true;
        }
    }
}
