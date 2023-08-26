using MVVMDemo.ViewModels;

namespace MVVMDemo.Views;

public partial class PeopleView : ContentPage
{
	PeopleViewModel people;
	int count = 0;
	public PeopleView()
	{
		InitializeComponent();
		people = new PeopleViewModel();
		BindingContext = people;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		count++;
		foreach(var item in people.Item) 
		{
			item.Weight = count;
			count++;
		}
    }
}