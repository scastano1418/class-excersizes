using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_26_thought_experiment
{
    class Lion : Animal
    {
        public Lion() : base("Lion")
        {

        }
        public override void MakeNoise()
        {
            Console.WriteLine(name + ": meow");
        }

    }
}
