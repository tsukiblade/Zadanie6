using System.ComponentModel;

namespace Zadanie6.Base
{
    public class ExtendedNotifyPropertyChanged : INotifyPropertyChanged
    {
        protected void SetProperty<T>(ref T source, T value)
        {
            source = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(source)));
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RaiseAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
