using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace NumberParserExtended
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"NumberParserExtended.txt");
            string content = File.ReadAllText(path);

            int height = 500;
            int width = 500;

            ConvertTextToImage(content, "Consolas", 10, Color.White, Color.Black, width, height);
            Console.Read();
        }

        public static Bitmap ConvertTextToImage(string txt, string fontname, int fontsize, Color bgcolor, Color fcolor, int width, int Height)
        {
            var bmp = new Bitmap(width, Height);

            using (var graphics = Graphics.FromImage(bmp))
            using (var font = new Font(fontname, fontsize))
            {
                graphics.FillRectangle(new SolidBrush(bgcolor), 0, 0, bmp.Width, bmp.Height);
                graphics.DrawString(txt, font, new SolidBrush(fcolor), 0, 0);
            }

            bmp.Save("E:\\" + Guid.NewGuid() + ".bmp");

            ConvertImageToText(bmp);
            return bmp;
        }

        public static void ConvertImageToText(Bitmap image)
        {
            Ocr ocr = new Ocr();
            using (Bitmap bmp = new Bitmap(image))
            {
                tessnet2.Tesseract tessocr = new tessnet2.Tesseract();
                tessocr.Init(null, "eng", false);
                tessocr.SetVariable("whitelist", "0123456789"); // digits only
                tessocr.GetThresholdedImage(bmp, Rectangle.Empty).Save("E:\\" + Guid.NewGuid().ToString() + ".bmp");
                // Tessdata directory must be in the directory than this exe
                Console.WriteLine("Multithread version");
                ocr.DoOCRMultiThred(bmp, "eng");
                ocr.DoOCRMultiThred(bmp, "eng");
                Console.WriteLine("Normal version");
                ocr.DoOCRNormal(bmp, "eng");
            }
        }
    }
}
