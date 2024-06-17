namespace dcit318_assignment2_10953871
{
    internal class AnimalProgram
    {
        static void Main(string[] args)
        {
            //Dog and Cat objects are created and their makeSound methods are called
            Dog josephTheDog = new Dog();
            josephTheDog.makeSound();

            Cat josephTheCat = new Cat();
            josephTheCat.makeSound();
        }

    }

    public class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }


    public class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }
    }

}
