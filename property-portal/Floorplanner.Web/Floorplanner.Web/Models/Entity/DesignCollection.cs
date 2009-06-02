using System.Xml.Serialization;

namespace Floorplanner.Web.Models.Entity
{
    [XmlRoot("designs")]
    public class DesignCollection
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("design")]
        public Design[] Designs { get; set; }

    }
}
