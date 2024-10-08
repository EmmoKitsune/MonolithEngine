using Raylib_cs;
using System;

public static class userEntities
{
    public class TESTEntity : MonolithCore.IBaseEntity
    {
        public void setup()
        {
            Console.WriteLine("Hello from TESTEntity");
        }
        public void update()
        { }
        public void draw()
        {
            Raylib.DrawRectangle(400, 400, 30, 30, Color.Red);
        }
        public void shutdown()
        {
            Console.WriteLine("Bye from TESTEntity");
        }
    }

    public static void init()
    {
        var entity1 = new TESTEntity();

        MonolithCore.entityManager.AddEntity(entity1);

        MonolithCore.entityManager.callInitMethod();
    }

    public static void update()
    {
        MonolithCore.entityManager.callUpdateMethod();
    }
    public static void draw()
    {
        MonolithCore.entityManager.callDrawMethod();
    }
    public static void shutdown()
    {
        MonolithCore.entityManager.callShutdownMethod();
    }
}
