namespace MAUIDelivery.Pages;

public partial class AddAddressPage : ContentPage
{
	public AddAddressPage()
	{
		InitializeComponent();
	}

	private void SaveAddress_Clicked(object sender, EventArgs e)
	{
		  Navigation.PopAsync();
	}
}