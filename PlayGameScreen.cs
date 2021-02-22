using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace AIE_33_Game_States
{
    class PlayGameScreen : GameState
    {


        public PlayGameScreen(Program program) : base(program)
        {

        }


        public override void Update()
        {

        }

        public override void Draw()
        {
            Raylib.DrawText("Play Game", 10, 10, 22, Color.GRAY);
        }

    }
}
