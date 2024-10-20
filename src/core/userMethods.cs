using Raylib_cs;

public static class userMethods
{
    public static void Setup()
    { }

    public static void Update()
    {
        
    }

    public static void Draw()
    {
        Raylib.DrawText("Monolith " + engineSetting.monolithVersion, 50, 200, 55, Color.White);
    }

    public static void Shutdown()
    { }
}
