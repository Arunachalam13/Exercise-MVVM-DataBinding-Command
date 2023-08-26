using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.ViewModels
{
    public class SimpleMVVMViewModel : INotifyPropertyChanged
    {
        private int number1;

        public int Number1
        {
            get { return number1; }
            set 
            { 
                number1 = value;
                OnPropertyChanged();
            }
        }

        private int number2;

        public int Number2
        {
            get { return number2; }
            set 
            { 
                number2 = value;
                OnPropertyChanged();
            }
        }

        private int result;

        public int Result
        {
            get { return result; }
            set 
            { 
                result = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }

        public SimpleMVVMViewModel()
        {
            AddCommand = new Command(() =>
            {
                Result = Number1 + Number2;

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
