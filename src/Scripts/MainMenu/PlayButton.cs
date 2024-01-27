using Godot;

namespace SuperMarigolo.Scripts.MainMenu;

public partial class PlayButton : Button
{
    private void _on_start_button_pressed()
    {
        if (GetTree().ChangeSceneToFile("res://FirstScene.tscn") != Error.Ok)
            GD.PrintErr("Failed to change scene to FirstScene.tscn");
        else
        {
            GetTree().ChangeSceneToFile("res://FirstScene.tscn");
        }
    }
}