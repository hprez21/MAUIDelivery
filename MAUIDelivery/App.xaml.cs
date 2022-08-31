using MAUIDelivery.Pages;

namespace MAUIDelivery;

public partial class App : Application
{
     public App()
     {
          InitializeComponent();
          MainPage = new NavigationPage(new HomePage());
     }
}
