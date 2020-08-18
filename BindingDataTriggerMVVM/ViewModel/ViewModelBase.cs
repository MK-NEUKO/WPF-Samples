using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Runtime.CompilerServices;
using System.Text;

namespace BindingDataTriggerMVVM.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyname = null)
        {
            if (Equals(storage, value)) return false;
            storage = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
            return true;
        }
    }
}
