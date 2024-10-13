using Raylib_cs;

public static class userMethods
{
    static float timeCounter = 0.0f;

    public static void Setup()
    { }

    public static void Update()
    {
        timeCounter += Raylib.GetFrameTime();
    }

    public static void Draw()
    {
        Raylib.DrawText("Monolith " + engineSetting.monolithVersion, 50, 200, 55, Color.White);

        Raylib.DrawText(timeCounter.ToString("F0"), 50, 300, 55, Color.White);
    }

    public static void Shutdown()
    { }
}
