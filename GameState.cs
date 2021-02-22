using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_33_Game_States
{
    class GameState
    {

        protected Program program; 

        public GameState(Program program)
        {
            this.program = program;
        }
        public virtual void Update()
        {
             
        }

        public virtual void Draw()
        {

        }
    }
}
