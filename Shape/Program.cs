namespace Shape
{
    internal class ShapeProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle");
            string radiusInput = Console.ReadLine();
            if (double.TryParse(radiusInput, out double radius))
            {
                Circle circle = new Circle(radius);
                circle.GetArea();
            }
            
        }
    }

    public abstract class Shape
    {
        public abstract void GetArea();
    }

    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;

        }

        public override void GetArea()
        {
            double area = Math.PI * _radius * _radius;
            Console.WriteLine($"The area of the circle with radius {_radius} is {area}");
        }
    }
}