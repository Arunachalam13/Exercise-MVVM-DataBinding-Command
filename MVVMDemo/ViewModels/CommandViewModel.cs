using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.ViewModels
{
    public class CommandViewModel
    {
        public ICommand ClickCommand => 
            new Command(() => 
            App.Current.MainPage.DisplayAlert("Message", "Welcome Direct command .NET MAUI", "Ok"));

        public ICommand MethodCommand => new Command(Alert);

        private void Alert()
        {
            App.Current.MainPage.DisplayAlert("Message", "Welcome Command and Method .NET MAUI", "Ok");
        }

        public ICommand ConstructCommand { get; set; }

        public ICommand CommandSearch { get; set; }

        public CommandViewModel()
        {
            ConstructCommand = new Command(() => App.Current.MainPage.DisplayAlert("Message", "Welcome Command and Method .NET MAUI", "Ok"));

            CommandSearch = new Command((s) =>
            {
                var data = s;
            });
        }

    }
}
