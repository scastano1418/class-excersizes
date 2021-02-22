﻿using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
    

namespace AIE_33_Game_States
{
    class MenuScreen : GameState
    {

        public MenuScreen(Program program) : base(program)
        {

        }

        public override void Update()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                program.ChangeGameState(new PlayGameScreen(program));
            }
        }

        public override void Draw()
        {
            Raylib.DrawText("Menu Screen", 10, 10, 22, Color.GRAY);
        }

    }
}
