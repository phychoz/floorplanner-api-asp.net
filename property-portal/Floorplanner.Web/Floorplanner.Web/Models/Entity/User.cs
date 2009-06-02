using System;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Floorplanner.Web.Models.Entity
{
    [ServiceContract]
    [XmlRoot("user")]
    public class User
    {
        [XmlElement("company")]
        public string Company { get; set; }

        [XmlElement("country-code")]
        public string CountryCode { get; set; }

        [XmlElement("created-at")]
        public DateTime? CreatedAt { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("external-identifier")]
        public string ExternalIdentifier { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("measurement-system")]
        public string MeasurmentSystem { get; set; }

        [XmlElement("profile")]
        public string Profile { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("username")]
        public string Username { get; set; }

        [XmlElement("account-type")]
        public string AccountType { get; set; }

        [XmlElement("current-token")]
        public string CurrentToken { get; set; }
    }
}
