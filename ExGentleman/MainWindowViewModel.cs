using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExGentleman.Models;

namespace ExGentleman
{
    public class MainWindowViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private int? _integerGreater10Property;
        public event PropertyChangedEventHandler PropertyChanged;

        public int? IntegerGreater10Property
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

        private void RaisePropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

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

        public List<People> Peoples { get; set; } = new List<People>()
        {
            new People(){EmpNo = "021867", EmpNme = "Jack", BirthDate = DateTime.Now},
            new People(){EmpNo = "024835", EmpNme = "Jack", BirthDate = DateTime.Now},
        };
    }
}
