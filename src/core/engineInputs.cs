using System.Runtime.CompilerServices;
using Raylib_cs;

public static class MonolithInput
{
    public static int GetAxis(KeyboardKey key1,KeyboardKey key2)
    {   
        if(Raylib.IsKeyDown(key1))
        {
            return 1;
        }
        else if (Raylib.IsKeyDown(key2))
        {
            return -1;
        }
        else if (Raylib.IsKeyDown(key1) && Raylib.IsKeyDown(key2))
        {
            return 0;
        }
        else
        {
            return 0;
        }
    }

    public static int GetAxisInverse(KeyboardKey key1,KeyboardKey key2)
    {
        return GetAxis(key2,key1);
    }
}