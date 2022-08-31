namespace MAUIDelivery.Pages;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
	}

	private async void Pay_Clicked(object sender, EventArgs e)
	{
		  paymentScreen.IsVisible = true;
		  animation.IsAnimationEnabled = true;
		  await Task.Delay(3000);
		  await Navigation.PushAsync(new StoresPage());
	}
}