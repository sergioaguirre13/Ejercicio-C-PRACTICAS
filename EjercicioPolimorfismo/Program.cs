namespace EjercicioPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var shapes = new List<Shape>();
            var rectangle = new Rectangle() { Width = 20, Height = 10 };
            var triangle = new Triangle() { Width = 10, Height = 15 };
            var square = new Square() { Width = 10 };

            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(square);


            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateArea());
            }




        }





        public abstract class Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public abstract double CalculateArea();
        }

        public class Square : Shape
        {
            public override double CalculateArea()
            {
                return Math.Pow(Width, 2);
            }
        }

        public class Rectangle : Shape
        {
            public override double CalculateArea()
            {
                return Width * Height;
            }
        }

        public class Triangle : Shape
        {
            public override double CalculateArea()
            {
                return (Width * Height) / 2;
            }
        }
    }
}
