using Raylib_cs;
using System;

public static class UserEntities
{
    public class TESTEntity : MonolithCore.IBaseEntity
    {
        public string entName = "TESTEntity";
        public int width = 30;
        public int height = 30;

        public int posX = 400;
        public int posY = 400;

        public void Setup()
        {
            Console.WriteLine(entName + " Inited;");
        }
        public void Update()
        { 
            if(posX < engineSetting.windowWidth + width)
            {
                posX += 2;
            }else
            {
                posX = (0-width);
            }
        }
        public void Draw()
        {
            Raylib.DrawRectangle(posX, posY, width, height, Color.Red);
        }
        public void Shutdown()
        {
            Console.WriteLine(entName + "shutdown;");
        }
    }

    public static void Init()
    {
        var entity1 = new TESTEntity();
        var entity2 = new TESTEntity
        {
            posX = 100
        };

        MonolithCore.entityManager.AddEntity(entity1);
        MonolithCore.entityManager.AddEntity(entity2);

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
