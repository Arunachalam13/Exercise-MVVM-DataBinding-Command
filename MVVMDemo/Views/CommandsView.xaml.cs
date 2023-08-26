using MVVMDemo.ViewModels;

namespace MVVMDemo.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandViewModel();
	}
}