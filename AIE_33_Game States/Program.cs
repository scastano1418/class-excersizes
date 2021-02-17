using System;
using Raylib_cs;


namespace AIE_33_Game_States
{
    class Program
    {
        int windowWidth = 800;
        int windowHeight = 450;
        string windowTitle = "GameStateManagement";

        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunGame();
        }

        void RunGame()
        {
            Raylib.InitWindow(windowWidth, windowHeight, windowTitle);
            Raylib.SetTargetFPS(60);

            LoadGame();

            while

            Raylib.CloseWindow(); 
        }

        void LoadGame()
        {


        }

        void Update()
        {

        }
        void Draw()
        {

        }
    }
}
