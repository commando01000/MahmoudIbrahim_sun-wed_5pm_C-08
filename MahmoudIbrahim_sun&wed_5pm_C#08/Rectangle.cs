using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C_08
{
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double _area { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Calculate_Area();
        }

        public double Area { get => _area; set => _area = value; }
        private void Calculate_Area()
        {
            _area = Width * Height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {this.Area}");
        }
    }
}
