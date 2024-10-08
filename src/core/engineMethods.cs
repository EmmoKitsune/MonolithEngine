using Raylib_cs;
using System;

public class MonolithCore
{
    public static EntitiesManager entityManager = new EntitiesManager();

    public interface IBaseEntity
    {
        public void setup();
        public void update();
        public void draw();
        public void shutdown();
    }

    public static void setup()
    {
        Console.WriteLine("Welcome to Monolith version " + engineSetting.monolithVersion);

        Raylib.InitWindow(engineSetting.windowWidth, engineSetting.windowHeight, engineSetting.windowTitle);

        Raylib.SetTargetFPS(engineSetting.maxFPS);

        Raylib.SetWindowIcon(Raylib.LoadImage("assets/monolithlogo.png"));

        if (engineSetting.debugMenu)
        {
            MonolithDebug.setup();
        }

        userMethods.setup();
        userEntities.init();
    }

    public static void update()
    {
        userMethods.update();
        userEntities.update();
    }

    public static void draw()
    {
        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.Black);

        userMethods.draw();
        userEntities.draw();

        if (engineSetting.debugMenu)
        {
            MonolithDebug.drawDebugMenu();
        }

        Raylib.EndDrawing();
    }

    public static void shutdown(int code)
    {
        userMethods.shutdown();
        userEntities.shutdown();
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
