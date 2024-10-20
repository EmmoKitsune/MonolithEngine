using rlImGui_cs;
using Raylib_cs;
using ImGuiNET;
using System.Text.RegularExpressions;

public static class MonolithDebug
{
    static string ConsoleContent = "";
    static int ConsoleIndex = 0;
    public static void setup()
    {
        rlImGui.Setup(engineSetting.debugMenuDarkMode);
    }

    public static void DrawDebugMenu()
    {
        rlImGui.Begin();

        if (ImGui.Begin("Debug window"))
        {
            ImGui.Text("Running game " + engineSetting.windowTitle + " on " + engineSetting.monolithVersion);
            ImGui.Separator();
            ImGui.Text("FPS: " + Raylib.GetFPS().ToString());
            ImGui.Text(engineSetting.windowWidth.ToString() + "px X " + engineSetting.windowHeight.ToString() + "px");
        }

        ImGui.End();

        if(ImGui.Begin("Console"))
        {
            ImGui.Text("Console:>>");

            if(ImGui.Button("Clear"))
            {
                ClearConsole();
            }

            ImGui.Separator();

            ImGui.Text(ConsoleContent);
        }
        ImGui.End();

        rlImGui.End();
    }

    public static void Shutdown()
    {
        rlImGui.Shutdown();
    }

    public static void PrintAtConsole(string message,int type)
    {
        switch(type)
        {
            case 0: // normal
                ConsoleContent += (ConsoleIndex.ToString() + ">: " + message + "\n");
                break;
            case 1: // warning
                ConsoleContent += ("WARNING/ " + ConsoleIndex.ToString() + ">: " + message + "\n");
                break;

            case 2: // error
                ConsoleContent += ("ERROR/ " + ConsoleIndex.ToString() + ">: " + message + "\n");
                break;
        }
        
        ConsoleIndex += 1;
    }

    public static void ClearConsole()
    {
        ConsoleContent = "";
        ConsoleIndex = 0;
    }
}
