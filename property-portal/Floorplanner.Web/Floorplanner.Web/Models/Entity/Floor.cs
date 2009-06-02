using System.Xml.Serialization;

namespace Floorplanner.Web.Models.Entity
{
    [XmlRoot("floor")]
    public class Floor
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("level")]
        public int Level { get; set; }

        [XmlElement("height")]
        public decimal Height { get; set; }

        [XmlElement("created-at")]
        public string CreatedAt { get; set; }

        [XmlElement("updated-at")]
        public string UpdatedAt { get; set; }

        [XmlElement("designs")]
        public DesignCollection Designs { get; set; }
    }
}
