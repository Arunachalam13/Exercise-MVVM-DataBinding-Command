using MVVMDemo.Models;
using MVVMDemo.ViewModels;

namespace MVVMDemo.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
		
	}
}