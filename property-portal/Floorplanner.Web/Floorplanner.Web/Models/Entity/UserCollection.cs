using System.Xml.Serialization;

namespace Floorplanner.Web.Models.Entity
{
    [XmlRoot("users")]
    public class UserCollection
    {
        [XmlElement("user")]
        public User[] Users { get; set; }

    }
}
