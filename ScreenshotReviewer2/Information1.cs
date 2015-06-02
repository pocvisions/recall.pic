using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace ScreenshotReviewer2

{
    [XmlRoot(Namespace = "ScreenshotReviewer2", DataType = "string", IsNullable = true)]
    [Serializable()]

    public class Information1
    {
        [XmlAttribute("Comments")]
        public string data1;

        [XmlAttribute("Tags")]
        public string data2;

        [XmlAttribute("Username")]
        public string data3;

        [XmlAttribute("Images1")]
        public string data4;

        [XmlAttribute("ImageStatus")]
        public string data5;

        [XmlAttribute("Languages")]
        public string data6;

        [XmlAttribute("Progress")]
        public string data7;

        [XmlAttribute("Images2")]
        public string data8;

        [XmlAttribute("Paths")]
        public string data9;

        [XmlAttribute("Roles")]
        public string data10;

        [XmlAttribute("ProjectName")]
        public string data11;
       
        public string Comments
        {
            get { return data1; }
            set { data1 = value; }
        }

        public string Tags
        {
            get { return data2; }
            set { data2 = value; }
        }

        public string Username
        {
            get { return data3; }
            set { data3 = value; }
        }

        public string Images1
        {
            get { return data4; }
            set { data4 = value; }
        }

        public string ImageStatus
        {
            get { return data5; }
            set { data5 = value; }
        }

        public string Languages
        {
            get { return data6; }
            set { data6 = value; }
        }

        public string Progress
        {
            get { return data7; }
            set { data7 = value; }
        }

        public string Images2
        {
            get { return data9; }
            set { data9 = value; }
        }

        public string Paths
        {
            get { return data9; }
            set { data9 = value; }
        }

        public string Roles
        {
            get { return data10; }
            set { data10 = value; }
        }

        public string ProjectName
        {
            get { return data11; }
            set { data11 = value; }
        }
    }

}
