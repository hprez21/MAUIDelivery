using MAUIDelivery.Models;

namespace MAUIDelivery.Pages;

public partial class OrderDetailPage : ContentPage
{
	 public Order CurrentOrder { get; set; }
	public OrderDetailPage()
	{
		InitializeComponent();
          CurrentOrder = new Order
		  {
			   Products = new List<Product>
			   {
                    new Product { Id = 4, Name = "Waffles", Image = "waffles.jpg", Description = "Warm and fluffy waffles topped with your choice of fruit, whipped cream, or maple syrup.", Price = 11, Quantity = 3 },
                    new Product { Id = 1, Name = "Pepperoni Pizza", Image = "pepperoni.jpg", Description = "A classic pepperoni pizza with a crispy crust and melty cheese.", Price = 12.72, Quantity = 1 },
                    new Product { Id = 8, Name = "Soda", Image = "soda.jpg", Description = "Drink up! Our delicious soda is the perfect thirst-quencher.", Price = 3, Quantity = 4 },
               }
		  };
		  BindingContext = this;
	}

	 private async void Checkout_Clicked(object sender, EventArgs e)
	 {
		  await Navigation.PushAsync(new PaymentPage());
	 }
}