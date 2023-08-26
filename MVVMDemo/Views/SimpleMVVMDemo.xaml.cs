using MVVMDemo.ViewModels;

namespace MVVMDemo.Views;

public partial class SimpleMVVMDemo : ContentPage
{
	public SimpleMVVMDemo()
	{
		InitializeComponent();
		BindingContext = new SimpleMVVMViewModel();
	}
}