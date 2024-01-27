using Godot;

namespace SuperMarigolo.Scripts.OptionMenu;

public partial class ReturnButton : Button
{
    private void _on_pressed()
    {
        if (GetTree().ChangeSceneToFile("res://Menu/MainMenu.tscn") != Error.Ok)
            GD.PrintErr("Failed to change scene to MainMenu.tscn");
        else
        {
            GetTree().ChangeSceneToFile("res://Menu/MainMenu.tscn");
        }
    }
}