using System;

namespace AIE_26_thought_experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeNoise();
             // Outputs: WOOF WOOF WOOF
                             // the overriden vrsion of the MakeNoise method is called

            Cat cat = new Cat();
            cat.MakeNoise(); // Outputs: Cat: Makes noise
                             // the default Animal's MakeNoise method is called


            Bird bird = new Bird();
            bird.MakeNoise(); // Outputs: Bird: Makes noise
                              // the default Animal's MakeNoise method is called


            Lion lion = new Lion();
            lion.MakeNoise();

        }
    }

    
    class Animal
    {
        public string name = "";

        // Constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine(name + ": makes noise");
        }

    }

}
