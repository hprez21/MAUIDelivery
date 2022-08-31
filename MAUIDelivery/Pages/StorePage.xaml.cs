using MAUIDelivery.Models;

namespace MAUIDelivery.Pages;

public partial class StorePage : ContentPage
{
	 public Store Store { get; set; }
     public List<Category> Categories { get; set; }
     
	public StorePage()
	{
		InitializeComponent();
          Store =
               new Store
               {
                    Id = 1,
                    Header = "header1.jpg",
                    Logo = "logo1.jpg",
                    Name = "maugly",
                    DeliveryTime = "30 - 40 mins",
                    Minimum = 150,
                    ServiceFee = 10,
                    Rating = 4.5
               };


          Categories = new List<Category>()
          {
               new Category
               {
                    Id = 1,
                    Name = "Starters",
                    Image = "cat_starters.jpg",
                    Color = "#813607"
               },
               new Category
               {
                    Id = 2,
                    Name = "Pizzas",
                    Image = "cat_pizzas.jpg",
                    Color = "#813607"
               },
               new Category
               {
                    Id = 3,
                    Name = "Burguers",
                    Image = "cat_burguers.jpg",
                    Color = "#813607"
               },
               new Category
               {
                    Id = 4,
                    Name = "Salads",
                    Image = "cat_salads.jpg",
                    Color = "#813607"
               },
               new Category
               {
                    Id = 5,
                    Name = "Drinks",
                    Image = "cat_drinks.jpg",
                    Color = "#813607"
               },
               new Category
               {
                    Id = 6,
                    Name = "Desserts",
                    Image = "cat_desserts.jpg",
                    Color = "#813607"
               },
          };

          BindingContext = this;
    }

    private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
          Navigation.PushAsync(new MenuPage());
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
          await Navigation.PushAsync(new OrderDetailPage());
     }
}