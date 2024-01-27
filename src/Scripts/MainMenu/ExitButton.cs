using Godot;

namespace SuperMarigolo.Scripts.MainMenu;

public partial class ExitButton : Button
{

    private void _on_pressed()
    {
        GetTree().Quit();
    }
}