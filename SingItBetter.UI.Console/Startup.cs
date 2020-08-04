using System;
using System.ComponentModel;
using SingItBetter.Interfaces.ViewModel;
using SingItBetter.UI.ViewModel;

namespace SingItBetter.UI.Console
{
    public class Startup
    {
        private readonly IMainViewModel _mainViewModel;

        public Startup(IMainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
        public void Run()
        {
            _mainViewModel.PropertyChanged += MainViewModelListener;
            _mainViewModel.TestCommand.Execute(_mainViewModel.CurrentDateTimeString);
            System.Console.ReadKey();
        }

        private void MainViewModelListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(_mainViewModel.TestString))
                System.Console.WriteLine($"{nameof(_mainViewModel.TestString)}: {_mainViewModel.TestString}");
        }
    }
}