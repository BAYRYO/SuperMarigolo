using Godot;

namespace SuperMarigolo.Scripts.MainMenu;

public partial class OptionsButton : Button
{
    private void _on_options_button_pressed()
    {
        if (GetTree().ChangeSceneToFile("res://Menu/OptionMenu.tscn") != Error.Ok)
            GD.PrintErr("Failed to change scene to OptionMenu.tscn");
        else
        {
            GetTree().ChangeSceneToFile("res://Menu/OptionMenu.tscn");
        }
    }
}