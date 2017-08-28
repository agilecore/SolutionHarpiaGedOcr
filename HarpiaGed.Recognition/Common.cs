using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HarpiaGed.Recognition
{
    public class Common
    {
        public static Image GetImage(string file)
        {
            var image = Image.FromFile(file);
            return (image);
        }
        public static Bitmap GetBitmap(string file)
        {
            var image = Image.FromFile(file);
            var bitmap = new Bitmap(image);
            return (bitmap);
        }

        ///// <summary>
        ///// Cria xml com as informacoes processadas do arquivo de imagem.
        ///// </summary>
        ///// <param name="directory">Ex: c:\folder</param>
        ///// <param name="fileName">Ex: output.xml</param>
        //public static void CreateXml(string directory, string fileName, )
        //{
        //    using (XmlWriter writer = XmlWriter.Create(String.Concat(directory, @"\" + fileName)))
        //    {
        //        writer.WriteStartDocument();
        //        writer.WriteStartElement("Employees");

        //        foreach (Employee employee in employees)
        //        {
        //            writer.WriteStartElement("Employee");

        //            writer.WriteElementString("ID", employee.Id.ToString());
        //            writer.WriteElementString("FirstName", employee.FirstName);
        //            writer.WriteElementString("LastName", employee.LastName);
        //            writer.WriteElementString("Salary", employee.Salary.ToString());

        //            writer.WriteEndElement();
        //        }

        //        writer.WriteEndElement();
        //        writer.WriteEndDocument();
        //    }
        //}
    }
}
