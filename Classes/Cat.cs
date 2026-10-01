
namespace UML_Klass_Diagram___Övning.Classes
{
    // Class for Cat, inheritance from Animal
    public class Cat : Animal
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
            Console.WriteLine("Meow!");
        }
    }
}
