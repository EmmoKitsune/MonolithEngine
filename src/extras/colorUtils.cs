using Raylib_cs;
using System;

public static class ColorsUtils
{
    private static readonly Random random = new();

    public static Color RandomColor()
    {
        int red = random.Next(0, 256);
        int blue = random.Next(0, 256);
        int green = random.Next(0, 256);

        return new Color(red, blue, green, 255);
    }
    public static Color RandomColorAlpha()
    {
        int red = random.Next(0, 256);
        int blue = random.Next(0, 256);
        int green = random.Next(0, 256);
        int alpha = random.Next(0,256);

        return new Color(red, blue, green, alpha);
    }
    public static Color Modulate(Color original,Color modulator)
    {
        return new Color(original.R * modulator.R,original.G * modulator.G,original.B * modulator.B,original.A);
    }
}
