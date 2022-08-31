using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MAUIDelivery;

public static class MauiProgram
{
     public static MauiApp CreateMauiApp()
     {
          var builder = MauiApp.CreateBuilder();
          builder
              .UseMauiApp<App>()
              .UseSkiaSharp()
              .ConfigureFonts(fonts =>
              {
                   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                   fonts.AddFont("FontAwesomeSolid.otf", "AwesomeSolid");
                   fonts.AddFont("latoblack.TTF", "black");
                   fonts.AddFont("latobold.TTF", "bold");
                   fonts.AddFont("latoitalic.TTF", "italic");
                   fonts.AddFont("latoregular.TTF", "regular");
              });

          return builder.Build();
     }
}
