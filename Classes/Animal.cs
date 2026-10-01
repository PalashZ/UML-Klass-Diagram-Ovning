
namespace UML_Klass_Diagram___Övning.Classes
{
    // Inheritace class for Animal
    public abstract class Animal
    {
        // Attributes 
        public string Name { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }

        }

        // Metod for class Animals
        public abstract void MakeSound();
    }
}
