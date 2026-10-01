
namespace UML_Klass_Diagram___Övning.Classes
{
    // Class for Dog, Inheritances from class Animal

    public class Dog : Animal
    {
        // Attributes
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }

        }

        // Metod
        public override void MakeSound()
        {
            Console.WriteLine("woof!");
        }
    }
}
