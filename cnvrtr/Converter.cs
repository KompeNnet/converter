using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;

namespace cnvrtr
{
    public class Converter
    {
        public void convertToBMP(string inputFile, string fileName)
        {
            Bitmap bitmap = new Bitmap(inputFile);
            bitmap.Save(fileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
        public void convertToGIF(string inputFile, string fileName)
        {
            Bitmap bitmap = new Bitmap(inputFile);
            bitmap.Save(fileName + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
        }
        public void convertToJPG(string inputFile, string fileName)
        {
            Bitmap bitmap = new Bitmap(inputFile);
            bitmap.Save(fileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        public void convertToPNG(string inputFile, string fileName)
        {
            Bitmap bitmap = new Bitmap(inputFile);
            bitmap.Save(fileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }
        public void convertToTIFF(string inputFile, string fileName)
        {
            Bitmap bitmap = new Bitmap(inputFile);
            bitmap.Save(fileName + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
        }
        public void convertToICO(string inputFile, string fileName)
        {
            Bitmap bitmap = new Bitmap(inputFile);
            bitmap.Save(fileName + ".ico", System.Drawing.Imaging.ImageFormat.Icon);
        }
        public void convertToWMF(string inputFile, string fileName)
        {
            Bitmap bitmap = new Bitmap(inputFile);
            bitmap.Save(fileName + ".wmf", System.Drawing.Imaging.ImageFormat.Wmf);
        }
    }
}
