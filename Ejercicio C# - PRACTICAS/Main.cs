namespace Ejercicio_C____PRACTICAS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
           

            Dog dog = new Dog();
            dog.Saludar();

            Cat cat = new Cat();
            cat.Saludar();


        }

        public abstract class Animal
        {
            public abstract void Saludar();
            
        }

        public class Dog : Animal
        {
            public override void Saludar()
            {
                Console.WriteLine("Hola soy un perro");
            }
        }

        public class Cat : Animal
        {
            public override void Saludar()
            {
                Console.WriteLine("Miau");
            }
        }
    }
}
