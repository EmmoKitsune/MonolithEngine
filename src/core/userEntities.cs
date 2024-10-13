using Raylib_cs;
using System;

public static class UserEntities
{
    public class TESTEntity : MonolithCore.IBaseEntity
    {
        readonly string entName = "TESTEntity";
        public void Setup()
        {
            Console.WriteLine(entName + " Inited;");
        }
        public void Update()
        { }
        public void Draw()
        {
            Raylib.DrawRectangle(400, 400, 30, 30, Color.Red);
        }
        public void Shutdown()
        {
            Console.WriteLine(entName + "shutdown;");
        }
    }

    public static void Init()
    {
        var entity1 = new TESTEntity();

        MonolithCore.entityManager.AddEntity(entity1);

        MonolithCore.entityManager.CallInitMethod();
    }

    public static void Update()
    {
        MonolithCore.entityManager.CallUpdateMethod();
    }
    public static void Draw()
    {
        MonolithCore.entityManager.CallDrawMethod();
    }
    public static void Shutdown()
    {
        MonolithCore.entityManager.CallShutdownMethod();
    }
}
