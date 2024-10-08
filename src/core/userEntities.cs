using Raylib_cs;
using System;

public static class userEntities
{
    public class TESTEntity : MonolithCore.IBaseEntity
    {
        public void setup()
        { }
        public void update()
        { }
        public void draw()
        { }
        public void shutdown()
        { }
    }

    public static void init()
    {
        var entity1 = new TESTEntity();

        MonolithCore.entityManager.AddEntity(entity1);

        MonolithCore.entityManager.callInitMethod();
    }
    public static void update()
    { }
    public static void draw()
    { }
    public static void shutdown()
    { }
}
