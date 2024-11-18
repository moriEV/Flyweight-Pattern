using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
namespace Flyweight_Pattern
{
    public class Character
    {
        public string? Name { get; set; }
        public Types Type { get; set; }
        public string? _image { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public Character(string name, Types type, string image)
        {
            Name = name;
            Type = type;
            _image = image;
        }
        public void Display()
        {
            Console.WriteLine($"Character {Name},\nType {Type},\nLevel {Level},\nExperience {Experience}");
            Image Picture = Image.FromFile($@"{_image}");
            Console.SetBufferSize((Picture.Width * 0x2), (Picture.Height * 0x2));
            FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0x0]);
            int FrameCount = Picture.GetFrameCount(Dimension);
            int Left = Console.WindowLeft, Top = Console.WindowTop;
            char[] Chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ' };
            Picture.SelectActiveFrame(Dimension, 0x0);
            for (int i = 0x0; i < Picture.Height/10; i++)
            {
                for (int x = 0x0; x < Picture.Width/10; x++)
                {
                    Color Color = ((Bitmap)Picture).GetPixel(x*10, i*10);
                    int Gray = (Color.R + Color.G + Color.B) / 0x3;
                    int Index = (Gray * (Chars.Length - 0x1)) / 0xFF;
                    Console.Write(Chars[Index]);
                }
                Console.Write('\n');
            }
        }
    }
}
