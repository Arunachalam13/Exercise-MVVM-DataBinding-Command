using MVVMDemo.ViewModels;
using MVVMDemo.Views;

namespace MVVMDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new PersonView();
        //MainPage = new PeopleView();
        //MainPage = new ConverterDemo();
        //MainPage = new CommandsView();
        MainPage = new SimpleMVVMDemo();
    }
}
