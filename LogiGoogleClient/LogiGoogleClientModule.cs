using System.Configuration;
using Ninject.Modules;

namespace LogiGoogleClient
{
    public class LogiGoogleClientModule : NinjectModule
    {
        public override void Load()
        {
            Bind<GoogleApiConfiguration>().ToConstant(new GoogleApiConfiguration
            {
                ApiKey = ConfigurationManager.AppSettings.Get("googleApiKey"),
                PlacesApiUrl = ConfigurationManager.AppSettings.Get("placesApiUrl")
            });
        }
    }
}