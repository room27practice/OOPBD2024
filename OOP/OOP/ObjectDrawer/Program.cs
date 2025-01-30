namespace ObjectDrawer
{
    internal class Program
    {
        static void Main()
        {
            var r1 = new Rectangle(10, 4);
            var r2 = new Rectangle(5, 6);
            var r3 = new Rectangle(8, 3);
            var r4 = new Rectangle(10, 10);

            var c1 = new Circle(10);
            var c2 = new Circle(8);
            var c3 = new Circle(3);
            var c4 = new Circle(6);


            List<IDrawable> figures = new List<IDrawable>();
            figures.Add(r1);
            figures.Add(r2);
            figures.Add(r3);
            figures.Add(r4);
            figures.Add(c1);
            figures.Add(c2);
            figures.Add(c3);
            figures.Add(c4);
            foreach (IDrawable item in figures)
            {
                Console.WriteLine($"Perimeter= {item.Perimeter:F2} m2.");
                item.DrawSelf();
                Console.WriteLine(new string('=', 30));
            }

        }
    }

    interface IDrawable
    {
        void DrawSelf();
        public double Perimeter { get; }
    }

    public class Rectangle : IDrawable
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public int Length { get; set; }
        public int Width { get; set; }

        public double Perimeter => 2 * (Width + Length);

        public void DrawSelf()
        {
            Console.WriteLine(new string('*', Length));
            for (int i = 0; i < Width - 1; i++)
            {
                Console.WriteLine("*" + new string(' ', Length - 2) + "*");
            }
            Console.WriteLine(new string('*', Length));
        }
    }
    public class Circle : IDrawable
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public int Radius { get; set; }

        public double Perimeter => 2 * 3.14 * Radius;

        public void DrawSelf()
        {
            Console.WriteLine("Za sega ne chertaem nishto");
        }
    }

}