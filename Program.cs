using UML_Klass_Diagram___Övning.Classes;

namespace UML_Klass_Diagram___Övning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Animals!");

            // Objects for class Dog 

            Dog dog = new Dog();
            dog.Name = "Simba";
            dog.Breed = "Pitbull";
            dog.Age = 3;
            dog.MakeSound();
            Console.WriteLine(dog.Name + " is a " + dog.Breed + " and is " + dog.Age + " Years old! ");
            
            // Objects for class Cat

            Cat cat = new Cat();
            cat.Name = "Wish";
            cat.Breed = "Perisan cat";
            cat.Age = 2;
            cat.MakeSound();
            Console.WriteLine(cat.Name + " is a " + cat.Breed + " and is " + cat.Age + " Years old! ");


            // Both of the classes has inheritce from the class Animal

        }
    }
}
