using System.Reflection.Metadata.Ecma335;

namespace MahmoudIbrahim_sun_wed_5pm_C_08
{
    internal class Program
    {
        public static bool validate (Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
       
        public static Point Read_Point_From_User()
        {
            Console.WriteLine("Enter x, y, z: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    if (double.TryParse(Console.ReadLine(), out double z))
                    {
                        Point p2 = new Point(x, y, z);
                        return p2;
                    }
                }
            }
            return new Point(0, 0, 0);
        }
        static void Main(string[] args)
        {
            #region Question_1

            //Point p1 = Read_Point_From_User();
            //Point p2 = Read_Point_From_User();

            //if (p1 == p2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False"); // false will be displayed because they have different addresses !
            //}

            //Point[] points = { p1, p2 };
            //Array.Sort(points, (a, b) => (a.X == b.X) ? a.Y.CompareTo(b.Y) : a.X.CompareTo(b.X));

            //// print sorted array
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point); // sorted points will be displayed based on their X and Y !
            //}

            //p2 = (Point)p1.Clone();

            //Console.WriteLine(p2); // cloning will be done successfully refrence and value will be copied !

            #endregion

            #region Question_2
            //IShape shape = new Circle(5);

            //shape.DisplayShapeInfo();

            //IShape shape2 = new Rectangle(5, 10);

            //shape2.DisplayShapeInfo();

            #endregion

            #region Question_3
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            D1 = new Duration(3600);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());
            
            D3 = D1 + D2;
            Console.WriteLine(D3.ToString());

            D3 = D1 + 7800;
            Console.WriteLine(D3.ToString());

            D3 = 666 + D3;
            Console.WriteLine(D3.ToString());

            D3 = ++D1;
            Console.WriteLine(D3.ToString());

            D3 = --D2;
            Console.WriteLine(D3.ToString());

            D1 = D1 - D2;
            Console.WriteLine(D1.ToString());

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");
            else
                Console.WriteLine("D1 is not greater than D2");

            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal to D2");
            else
                Console.WriteLine("D1 is not less than or equal to D2");

            if (D1)
                Console.WriteLine("D1 is non-zero");
            else
                Console.WriteLine("D1 is zero");

            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt.ToString("HH:mm:ss"));
            #endregion
        }
    }
}
