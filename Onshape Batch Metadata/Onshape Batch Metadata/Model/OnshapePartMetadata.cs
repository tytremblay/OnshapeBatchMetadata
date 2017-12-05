using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onshape.Api.Client.Model
{
    public class OnshapePartMetadata
    {
        public string state { get; set; }
        public string description { get; set; }
        public string partQuery { get; set; }
        public string partId { get; set; }
        public string microversionId { get; set; }
        public string revision { get; set; }
        public string elementId { get; set; }
        public string partNumber { get; set; }
        public string bodyType { get; set; }
        public Boolean isMesh { get; set; }
        public Boolean isFlattenedBody { get; set; }
        public string configurationId { get; set; }
        public Boolean isHidden { get; set; }
        public int ordinal { get; set; }
        public string name { get; set; }
        public OnshapeMaterial material { get; set; }
        public OnshapeAppearance appearance { get; set; }
    }
}
