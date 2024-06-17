using System.Transactions;

namespace Shape
{
    internal class ShapeProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("""
                Select a shape
                1. Circle
                2. Rectangle

                """);

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the radius of the circle");
                    string radiusInput = Console.ReadLine();
                    if (double.TryParse(radiusInput, out double radius))
                    {
                        Circle circle = new Circle(radius);
                        circle.GetArea();
                    }
                    break;
                case "2":
                    
                    Console.WriteLine("Enter the lenght and breadth of the rectangle");
                    Console.WriteLine("Enter lenght");
                    string lenghtInput = Console.ReadLine()!;
                    Console.WriteLine("Enter breadth");
                    string breadthInput = Console.ReadLine()!;

                    if (double.TryParse(lenghtInput, out double lenght) && double.TryParse(breadthInput, out double breadth))
                    {
                        Rectangle rectangle = new Rectangle(lenght, breadth);
                        rectangle.GetArea();
                    }
                    else {                         
                        Console.WriteLine("Invalid input, Please enter a number");
                    }
                    break;

                default:  
                    Console.WriteLine("Invalid choice");
                   break;
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

    public class Rectangle: Shape
    {
        private double _length, _breadth;

        public Rectangle(double length, double breadth)
        {
            _breadth = breadth;
            _length = length;

        }

        public override void GetArea()
        {
           double area = _length * _breadth;
            Console.WriteLine($"Area of the rectangle is {area}");
        }
    }
}