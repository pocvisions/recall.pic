using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ScreenshotReviewer2
{
    [XmlRoot("ScreenshotReviewer2")]
    class Information1Container
    {
        [XmlArray("ScreenshotReviewer2")]
        [XmlArrayItem("XMLInformation")]
        public List<Information1> myNewXML = new List<Information1>();
    }
}
