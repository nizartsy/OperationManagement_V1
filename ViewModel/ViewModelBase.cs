using System.ComponentModel;

namespace OperationManagement_UI.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SetValue<T>(ref T value, T currentValue, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(value, currentValue)) return;

            value = currentValue;
            OnPropertyChanged(propertyName);
        }

    }
}
