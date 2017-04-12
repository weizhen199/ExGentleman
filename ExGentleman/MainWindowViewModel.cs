using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGentleman
{
    public class MainWindowViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private int? _integerGreater10Property;
        public event PropertyChangedEventHandler PropertyChanged;

        private int? IntegerGreater10Property
        {
            get { return this._integerGreater10Property; }
            set
            {
                if (Equals(value, _integerGreater10Property))
                {
                    return;
                }

                _integerGreater10Property = value;
                RaisePropertyChanged("IntegerGreater10Property");
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "IntegerGreater10Property" && this.IntegerGreater10Property < 10)
                {
                    return "Number is not greater than 10!";
                }
                return null;
            }
        }

        public string Error => string.Empty;
    }
}
