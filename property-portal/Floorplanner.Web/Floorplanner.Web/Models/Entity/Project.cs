using System;
using System.Xml.Serialization;

namespace Floorplanner.Web.Models.Entity
{
    [XmlRoot("project")]
    public class Project
    {
        [XmlElement("created-at")]
        public string CreatedAt { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("element-library-id")]
        public int ElementLibraryId { get; set; }

        [XmlElement("enable-autosave")]
        public bool EnableAutosave { get; set; }

        [XmlElement("external-identifier")]
        public string ExternalIdentifier { get; set; }

        [XmlElement("grid-cell-size")]
        protected string GridCellSizeString { get; set; }


        private decimal? _gridCellSize;
        public decimal? GridCellSize
        {
            get
            {
                if (!String.IsNullOrEmpty(GridCellSizeString))
                {
                    return Convert.ToDecimal(GridCellSizeString);
                }
                else
                {
                    return null;
                }
            }

            set { _gridCellSize = Convert.ToDecimal(value); }
        }

        [XmlElement("grid-sub-cell-size")]
        public string GridSubCellSizeString { get; set; }

        private decimal? _gridSubCellSize;
        public decimal? GridSubCellSize
        {
            get
            {
                if (!String.IsNullOrEmpty(GridSubCellSizeString))
                {
                    return Convert.ToDecimal(GridSubCellSizeString);
                }
                else
                {
                    return null;
                }
            }

            set { _gridSubCellSize = Convert.ToDecimal(value); }
        }

        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("original-project-id")]
        protected string OriginalProjectIdString { get; set; }

        private int? _originalProjectId;
        public int? OriginalProjectId
        {
            get
            {
                if (!String.IsNullOrEmpty(OriginalProjectIdString))
                {
                    return Convert.ToInt32(OriginalProjectIdString);
                }
                else
                {
                    return null;
                }
            }

            set { _originalProjectId = Convert.ToInt32(value); }
        }

        [XmlElement("project-url")]
        public string ProjectUrl { get; set; }

        [XmlElement("public")]
        public bool Public { get; set; }

        [XmlElement("texture-library-id")]
        public int TextureLibraryId { get; set; }

        [XmlElement("updated-at")]
        public string UpdateAt { get; set; }

        [XmlElement("user-id")]
        public int UserId { get; set; }

        [XmlElement("wall-thickness")]
        public decimal WallThickness { get; set; }

        [XmlElement("floors-count")]
        public int? FloorsCount { get; set; }

        [XmlElement("floors")]
        public FloorCollection Floors { get; set; }

        [XmlElement("designs-count")]
        public int? DesignsCount { get; set; }
    }
}
