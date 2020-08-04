using System;

namespace SingItBetter.Interfaces.ViewModel
{
    public interface IMainViewModel : IBaseViewModel
    {
        ICommandHandler TestCommand { get; }
        string TestString { get; set; }
        Func<string> CurrentDateTimeString { get; }
    }
}