using System.ComponentModel;
using System.Runtime.CompilerServices;
using SingItBetter.Interfaces.ViewModel;
using SingItBetter.UI.ViewModel.Annotations;

namespace SingItBetter.UI.ViewModel.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged, IBaseViewModel
    {
        #region Generated
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}