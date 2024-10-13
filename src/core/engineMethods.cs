using Raylib_cs;
using System;

public class MonolithCore
{
    public static EntitiesManager entityManager = new();

    public interface IBaseEntity
    {
        public void Setup();
        public void Update();
        public void Draw();
        public void Shutdown();
    }

    public static void Setup()
    {
        Console.WriteLine("Welcome to Monolith version " + engineSetting.monolithVersion);

        Raylib.InitWindow(engineSetting.windowWidth, engineSetting.windowHeight, engineSetting.windowTitle);

        Raylib.SetTargetFPS(engineSetting.maxFPS);

        Raylib.SetWindowIcon(Raylib.LoadImage("assets/monolithlogo.png"));

        if (engineSetting.debugMenu)
        {
            MonolithDebug.setup();
        }

        userMethods.Setup();
        UserEntities.Init();
    }

    public static void Update()
    {
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
            MonolithDebug.drawDebugMenu();
        }

        Raylib.EndDrawing();
    }

    public static void Shutdown(int code)
    {
        userMethods.Shutdown();
        UserEntities.Shutdown();
        if (engineSetting.debugMenu)
        {
            MonolithDebug.shutdown();
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
