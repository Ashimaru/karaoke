using System.ComponentModel;

namespace SingItBetter.Interfaces.ViewModel
{
    public interface IBaseViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;
    }
}