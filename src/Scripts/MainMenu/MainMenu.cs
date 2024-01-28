using Godot;
using System;
using SuperMarigolo.Scripts.Sounds;

public partial class MainMenu : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		BackgroundMusic.PlayMusic();
	}
}
