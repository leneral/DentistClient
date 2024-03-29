using System;
using System.Drawing;
using System.IO;

namespace Model.ImageManager
{
    public class ImageManager
    {
        public static byte[] GetBytes(Image img)
        {
            byte[] photoByte = null;

            if (!img.Equals(null))
            {
                using (var ms = new MemoryStream())
                {
                    var bmp = new Bitmap(img);
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    photoByte = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photoByte, 0, Convert.ToInt32(ms.Length));
                    bmp.Dispose();
                }
            }
            return photoByte;
        }  
    }
}
