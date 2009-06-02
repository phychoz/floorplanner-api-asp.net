using System.Xml.Serialization;

namespace Floorplanner.Web.Models.Entity
{
    [XmlRoot("projects")]
    public class ProjectCollection
    {
        [XmlElement("project")]
        public Project[] Projects { get; set; }

    }
}
