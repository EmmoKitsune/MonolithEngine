using rlImGui_cs;
using Raylib_cs;
using ImGuiNET;

public static class MonolithDebug
{
    public static void setup()
    {
        rlImGui.Setup(engineSetting.debugMenuDarkMode);
    }

    public static void drawDebugMenu()
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
        rlImGui.End();
    }

    public static void shutdown()
    {
        rlImGui.Shutdown();
    }
}
