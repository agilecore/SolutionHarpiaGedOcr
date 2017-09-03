using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HarpiaGed.Recognition
{

    /// <summary>
    /// Metodos axiliares de processamento de imagem.
    /// </summary>
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
            image.Dispose();
            return (bitmap);
        }

        public static byte[] ImageToByteArrayFromFilePath(string file)
        {
            var image = Image.FromFile(file);
            var imageConverter = new ImageConverter();
            var byteFromImage  = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
            image.Dispose();
            return (byteFromImage);
        }

        public static byte[] ImageToByteArrayFromImage(System.Drawing.Image image)
        {
            var imageConverter = new ImageConverter();
            var byteFromImage = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
            return (byteFromImage);
        }
        
        public static Decimal AspectRate(string file)
        {
            var image  = Image.FromFile(file);
            var bitmap = new Bitmap(image);
            image.Dispose();
            return (bitmap.Width > bitmap.Height) ? decimal.Divide(Convert.ToDecimal(bitmap.Width), Convert.ToDecimal(bitmap.Height)) : decimal.Divide(Convert.ToDecimal(bitmap.Height), Convert.ToDecimal(bitmap.Width));
        }

        internal static Metafile GetMetafile(string file)
        {
            var image = Image.FromFile(file);
            var graphics = Graphics.FromImage(image);
            var metafile = new Metafile(file, graphics.GetHdc(), new Rectangle(0, 0, 101, 101), MetafileFrameUnit.Pixel);
            image.Dispose();
            graphics.Dispose();
            return (metafile);
        }

        public static string GetFileSize(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            var result = GetFileSize(fileInfo.Length);            
            return (result);
        }

        internal static string GetFileSize(long bytes)
        {
            if (bytes < 0) throw new ArgumentException("bytes");

            double humano;
            string sufixo;

            if (bytes >= 1152921504606846976L) // Exabyte (1024^6)
            {
                humano = bytes >> 50;
                sufixo = "EB";
            }
            else if (bytes >= 1125899906842624L) // Petabyte (1024^5)
            {
                humano = bytes >> 40;
                sufixo = "PB";
            }
            else if (bytes >= 1099511627776L) // Terabyte (1024^4)
            {
                humano = bytes >> 30;
                sufixo = "TB";
            }
            else if (bytes >= 1073741824) // Gigabyte (1024^3)
            {
                humano = bytes >> 20;
                sufixo = "GB";
            }
            else if (bytes >= 1048576) // Megabyte (1024^2)
            {
                humano = bytes >> 10;
                sufixo = "MB";
            }
            else if (bytes >= 1024) // Kilobyte (1024^1)
            {
                humano = bytes;
                sufixo = "KB";
            }
            else return bytes.ToString("0 B"); // Byte

            humano /= 1024;
            return humano.ToString("0.## ") + sufixo;
        } 

        public static System.Drawing.Imaging.ImageFormat GetImageFormat(System.Drawing.Image image)
        {
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
                return System.Drawing.Imaging.ImageFormat.Bmp;
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                return System.Drawing.Imaging.ImageFormat.Png;
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Emf))
                return System.Drawing.Imaging.ImageFormat.Emf;
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
                return System.Drawing.Imaging.ImageFormat.Exif;
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                return System.Drawing.Imaging.ImageFormat.Gif;
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
                return System.Drawing.Imaging.ImageFormat.Icon;
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
                return System.Drawing.Imaging.ImageFormat.MemoryBmp;
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
                return System.Drawing.Imaging.ImageFormat.Tiff;
            else { return System.Drawing.Imaging.ImageFormat.Wmf; }                
        }

        public static string GetImageFormatString(System.Drawing.Image image)
        {
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                return System.Drawing.Imaging.ImageFormat.Jpeg.ToString();
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
                return System.Drawing.Imaging.ImageFormat.Bmp.ToString();
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                return System.Drawing.Imaging.ImageFormat.Png.ToString();
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Emf))
                return System.Drawing.Imaging.ImageFormat.Emf.ToString();
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
                return System.Drawing.Imaging.ImageFormat.Exif.ToString();
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                return System.Drawing.Imaging.ImageFormat.Gif.ToString();
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
                return System.Drawing.Imaging.ImageFormat.Icon.ToString();
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
                return System.Drawing.Imaging.ImageFormat.MemoryBmp.ToString();
            if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
                return System.Drawing.Imaging.ImageFormat.Tiff.ToString();
            else { return System.Drawing.Imaging.ImageFormat.Wmf.ToString(); }
        }

        public static void CreateXml(string directory, string fileName, InfoImage infoImage)
        {
            using (XmlWriter writer = XmlWriter.Create(String.Concat(directory, @"\" + fileName)))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("image");
                
                //foreach (Employee employee in employees)
                //{
                //    writer.WriteStartElement("Employee");

                //    writer.WriteElementString("ID", employee.Id.ToString());
                //    writer.WriteElementString("FirstName", employee.FirstName);
                //    writer.WriteElementString("LastName", employee.LastName);
                //    writer.WriteElementString("Salary", employee.Salary.ToString());

                //    writer.WriteEndElement();
                //}

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
