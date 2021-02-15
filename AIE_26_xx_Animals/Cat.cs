using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_26_thought_experiment
{
    class Cat : Animal
    {
        // Cat constructor
        public Cat() : base("Cat")
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine(name + ":ROAR");

        }
    }
}
