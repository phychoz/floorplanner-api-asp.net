using System;
using System.Xml.Serialization;

namespace Floorplanner.Web.Models.Entity
{
    [XmlRoot("design")]
    public class Design
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("design-type")]
        public string DesignType { get; set; }

        [XmlElement("thumb-url")]
        public string ThumbUrl { get; set; }

        [XmlElement("created-at")]
        public string CreatedAt { get; set; }

        [XmlElement("updated-at")]
        public string UpdatedAt { get; set; }

        [XmlElement("project-id")]
        public int ProjectId { get; set; }

        [XmlElement("floor-id")]
        public int FloorId { get; set; }
    }
}
