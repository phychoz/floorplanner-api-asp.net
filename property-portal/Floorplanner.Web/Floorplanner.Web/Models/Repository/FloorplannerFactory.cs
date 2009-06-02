using System.ServiceModel;
using System.Configuration;

namespace Floorplanner.Web.Models.Repository
{
    public static class FloorplannerFactory
    {
        public static ChannelFactory<IFloorplannerApi> GetFloorPlannerCatory()
        {
            var factory = new ChannelFactory<IFloorplannerApi>("FloorplannerREST");
            factory.Credentials.UserName.UserName = ConfigurationManager.AppSettings["APIKey"];
            factory.Credentials.UserName.Password = ConfigurationManager.AppSettings["Password"]; ;

            return factory;
        }
    }
}
