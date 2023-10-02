using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace xf.simp2023.notes.Helpers
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string _propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propertyName));
        }
    }
}

