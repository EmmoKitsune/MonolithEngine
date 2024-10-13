using Raylib_cs;

class Program
{
    static void Main()
    {
        MonolithCore.Setup();

        while (!Raylib.WindowShouldClose())
        {
            MonolithCore.Update();
            MonolithCore.Draw();
        }
        MonolithCore.Shutdown(0);
    }
}
