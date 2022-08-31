namespace MAUIDelivery.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	 private void Login_Clicked(object sender, EventArgs e)
	 {
		  Navigation.PushAsync(new StoresPage());

	 }

	 private async void CreateAccount_Clicked(object sender, EventArgs e)
	 {
		  await Navigation.PushAsync(new CreateAccountPage());
	 }
}