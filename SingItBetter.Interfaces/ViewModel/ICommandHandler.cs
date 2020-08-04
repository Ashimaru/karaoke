using System.Windows.Input;

namespace SingItBetter.Interfaces.ViewModel
{
    public interface ICommandHandler : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}