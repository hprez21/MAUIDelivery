using MAUIDelivery.Models;

namespace MAUIDelivery.Pages;

public partial class MenuPage : ContentPage
{
     public List<Product> MenuFiltrado { get; set; }
     public List<Category> Categories { get; set; }
     public MenuPage()
     {
          InitializeComponent();
          LoadData();


          BindingContext = this;
     }

     private void LoadData()
     {
          Categories = new List<Category>()
          {
               new Category
               {
                    Id = 1,
                    Name = "Starters",
                    Image = "cat_starters.jpg",
                    Color = "#a393bf"
               },
               new Category
               {
                    Id = 2,
                    Name = "Pizzas",
                    Image = "cat_pizzas.jpg",
                    Color = "#ef7b45"
               },
               new Category
               {
                    Id = 3,
                    Name = "Burguers",
                    Image = "cat_burguers.jpg",
                    Color = "#42443e"
               },
               new Category
               {
                    Id = 4,
                    Name = "Salads",
                    Image = "cat_salads.jpg",
                    Color = "#ed474a"
               },
               new Category
               {
                    Id = 5,
                    Name = "Drinks",
                    Image = "cat_drinks.jpg",
                    Color = "#cfd11a"
               },
               new Category
               {
                    Id = 6,
                    Name = "Desserts",
                    Image = "cat_desserts.jpg",
                    Color = "#e6f8b2"
               },
          };

          MenuFiltrado = new List<Product>
          {
                new Product { Id = 1, Name = "Pepperoni Pizza", Image = "pepperoni.jpg", Description = "A classic pepperoni pizza with a crispy crust and melty cheese.", Price = 12.72 },
                   new Product { Id = 2, Name = "Spaguetti", Image = "spaguetti.jpg", Description = "A classic Italian pasta dish made with a tomato sauce and ground beef.", Price = 15 },
                   new Product { Id = 3, Name = "Pancakes", Image = "pancakes.jpg", Description = "A stack of delicious pancakes, made with love.", Price = 9.99 },
                   new Product { Id = 4, Name = "Waffles", Image = "waffles.jpg", Description = "Warm and fluffy waffles topped with your choice of fruit, whipped cream, or maple syrup.", Price = 11 },
                   new Product { Id = 5, Name = "Coffee", Image = "coffee.jpg", Description = "A rich and flavorful coffee that is perfect for any time of day.", Price = 3 },
                   new Product { Id = 6, Name = "Cake", Image = "cake.jpg", Description = "A delicious cake made from scratch with the freshest ingredients.", Price = 7.5 },
                   new Product { Id = 7, Name = "Hamburguer", Image = "hamburguer.jpg", Description = "Enjoy a delicious hamburger made with fresh, ground beef and topped with your choice of condiments.", Price = 20 },
                   new Product { Id = 8, Name = "Soda", Image = "soda.jpg", Description = "Drink up! Our delicious soda is the perfect thirst-quencher.", Price = 3 },
                   new Product { Id = 9, Name = "Caesar's Salad", Image = "salad.jpg", Description = "A classic Caesar salad with chopped Romaine lettuce and croutons, tossed in our homemade Caesar dressing.", Price = 13 },
                   new Product { Id = 10, Name = "Lobster", Image = "lobster.jpg", Description = "Fresh lobster, poached and served chilled with drawn butter.", Price = 35 }
          };

     }

    private void Product_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
          Navigation.PushAsync(new ProductPage());
    }

     private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
     {
          await Navigation.PushAsync(new OrderDetailPage());
     }
}