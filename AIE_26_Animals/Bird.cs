using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_26_thought_experiment
{
    class Bird : Animal
    {
        // Bird constructor
        public Bird() : base("Bird")
        {
        }
        public override void MakeNoise()
        {
            Console.WriteLine(name + ": ChIrP");

        }
    }
}
