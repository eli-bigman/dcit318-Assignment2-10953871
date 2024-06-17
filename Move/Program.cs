namespace Move
{
    public class MoveProgram
    {

        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();

            Bicycle bicycle = new Bicycle();
            bicycle.Move();

        }

        internal interface IMovable
        {
            void Move();
        }

        public class Car() : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Car is moving");
            }
        }

        public class Bicycle()
        {
            public void Move()
            {
                Console.WriteLine("Bicycle is moving");
            }
        }
    }
      
}