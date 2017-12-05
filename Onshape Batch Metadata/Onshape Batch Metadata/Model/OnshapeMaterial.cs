using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onshape.Api.Client.Model
{
    public class OnshapeMaterial
    {
        public string displayName { get; set; }
        public string id { get; set; }
        public OnshapeLibraryReference libraryReference { get; set; }
        public string libraryName { get; set; }
        public List<OnshapeMaterialProperties> properties { get; set; }
    }
}
