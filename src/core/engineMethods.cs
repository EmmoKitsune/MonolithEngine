using Raylib_cs;
using System;

public class MonolithCore
{
    public static EntitiesManager entityManager = new();

    public static float RuntimeTimer = 0.0f;

    public interface IBaseEntity
    {
        public void Setup();
        public void Update();
        public void Draw();
        public void Shutdown();
    }

    public static void Setup()
    {
        MonolithDebug.PrintAtConsole("Welcome to Monolith version " + engineSetting.monolithVersion,0);

        Raylib.InitWindow(engineSetting.windowWidth, engineSetting.windowHeight, engineSetting.windowTitle);

        Raylib.SetTargetFPS(engineSetting.maxFPS);

        Raylib.SetWindowIcon(Raylib.LoadImage("assets/monolithlogo.png"));

        if (engineSetting.debugMenu)
        {
            MonolithDebug.setup();
        }

        MonolithDebug.PrintAtConsole("Engine loaded!",0);

        userMethods.Setup();
        UserEntities.Init();
    }

    public static void Update()
    {
        RuntimeTimer += Raylib.GetFrameTime();
        userMethods.Update();
        UserEntities.Update();
    }

    public static void Draw()
    {
        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.Black);

        userMethods.Draw();
        UserEntities.Draw();

        if (engineSetting.debugMenu)
        {
            MonolithDebug.DrawDebugMenu();
        }

        Raylib.EndDrawing();
    }

    public static void Shutdown(int code)
    {
        userMethods.Shutdown();
        UserEntities.Shutdown();
        if (engineSetting.debugMenu)
        {
            MonolithDebug.Shutdown();
        }
        Raylib.CloseWindow();

        //DONT MODIFY
        if (code != 0)
        {
            Console.WriteLine("Ouch,an error >:(,CODE: " + code.ToString());
        }
        else
        {
            Console.WriteLine("Closing Monolith app: " + engineSetting.windowTitle);
        }
        //DONT MODIFY
    }
}
