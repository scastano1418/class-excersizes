using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_26_thought_experiment
{
    class Dog : Animal
    {
        // Dog constructor
        public Dog() : base("Dog")
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine(name + ": WOOF");
        }
    } 
}
