using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onshape.Api.Client.Model
{
    public class OnshapeLibraryReference
    {
        public string documentId { get; set; }
        public string versionId { get; set; }
        public string elementMicroversionId { get; set; }
        public string elementId { get; set; }
    }
}
