
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace BrokHub_ConverObjectToAnimation.MVVM.Base
{
    public class Notify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NoifyEvent(string target)
        {
            if (PropertyChanged is not null)
                PropertyChanged(this, new PropertyChangedEventArgs(target));
        }
        public void FillCommand(ref ICommand command, Action<object> execute, Predicate<object> canexecute)
        {
            if (command is null)
                command = new IBaseCommand(execute, canexecute);
        }

        internal void FillCommand(ref object exit, Action<object> close_Click, object canClose_Click)
        {
            throw new NotImplementedException();
        }
    }
}
