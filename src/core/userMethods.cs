using Raylib_cs;

public static class userMethods
{
    static float timeCounter = 0.0f;

    public static void setup()
    { }

    public static void update()
    {
        timeCounter += Raylib.GetFrameTime();
    }

    public static void draw()
    {
        Raylib.DrawText("Monolith " + engineSetting.monolithVersion, 50, 200, 55, Color.White);

        Raylib.DrawText(timeCounter.ToString("F0"), 50, 300, 55, Color.White);
    }

    public static void shutdown()
    { }
}
