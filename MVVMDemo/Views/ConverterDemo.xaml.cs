using MVVMDemo.ViewModels;

namespace MVVMDemo.Views;

public partial class ConverterDemo : ContentPage
{
	public ConverterDemo()
	{
		InitializeComponent();
		BindingContext = new ConverterViewModel();
	}
}