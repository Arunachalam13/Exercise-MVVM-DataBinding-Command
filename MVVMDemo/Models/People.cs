using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.Models
{
    public class People : INotifyPropertyChanged
    {
        private string _name;
        private int _age;
        private bool _married;
        private int _weight;
        private DateTime _birthdate;
        private TimeSpan _lunchtime;
        public string Name { get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public int Age { get => _age;
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        public bool Married 
        { 
            get => _married;
            set
            {
                _married = value;
                OnPropertyChanged();
            }
        }

        public DateTime BirthDate 
        { 
            get => _birthdate;
            set
            {
                _birthdate = value;
                OnPropertyChanged();
            }
        }

        public int Weight 
        { 
            get => _weight;
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }

        public TimeSpan Lunchtime 
        { 
            get => _lunchtime;
            set
            {
                _lunchtime = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
