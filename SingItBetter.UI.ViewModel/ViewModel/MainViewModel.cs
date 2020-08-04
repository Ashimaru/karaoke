using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SingItBetter.Interfaces.ViewModel;
using SingItBetter.UI.ViewModel.Annotations;

namespace SingItBetter.UI.ViewModel.ViewModel
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        private readonly ISampleService _sampleService;

        public MainViewModel(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }
        private ICommandHandler _testCommand;
        private string _testString;

        public ICommandHandler TestCommand =>
            _testCommand ?? (_testCommand = new CommandHandler<Func<string>>(Test, () => true));


        public string TestString        
        {
            get => _testString;
            set
            {
                if (value == _testString) return;
                _testString = value;
                OnPropertyChanged();
            }
        }

        public Func<string> CurrentDateTimeString => () => $"Test {DateTime.Now:dd-MM-yyy HH:mm:ss}";

        private void Test(Func<string> func)
        {
            TestString = func();
        }
    }
}