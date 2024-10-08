using Raylib_cs;

class Program
{
    static void Main(string[] args)
    {
        MonolithCore.setup();

        while (!Raylib.WindowShouldClose())
        {
            MonolithCore.update();
            MonolithCore.draw();
        }
        MonolithCore.shutdown(0);
    }
}
