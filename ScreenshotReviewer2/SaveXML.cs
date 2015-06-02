using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.IO.MemoryMappedFiles;

namespace ScreenshotReviewer2
{
    public class SaveXML
    {
        public static void SaveData(object obj, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }

        /*/Create the document structure
                XmlNode pics = SaveXML.CreateElement("pictures");
                XmlNode pic = SaveXML.CreateElement("picture");
                pics.AppendChild(pic);
                SaveXML.AppendChild(pics);

                //Read the bitmap.
                string data = null;
                Bitmap bmp = new Bitmap(@"e:Image.bmp");
                using (MemoryStream mem = new MemoryStream())
                {
                    bmp.Save(mem, System.Drawing.Imaging.ImageFormat.Bmp);
                    //Convert the bytes to a string.
                    data = Convert.ToBase64String(mem.ToArray());
                }

                //Save the data and the document.
                pic.InnerText = data;
                SaveXML.Save(@"e:C:/Users/a.johnson/Desktop/C#Projects/Complete Picture Viewer tutorial sample/Data/AssetConfirmation.xml");
        */

    }
}
