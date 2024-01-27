using Godot;
using System;

public partial class QuitButton : Button
{
    public void _on_pressed()
    {
        GetTree().ChangeSceneToFile("res://Interfaces/Menu/MainMenu.tscn");
    }
}
