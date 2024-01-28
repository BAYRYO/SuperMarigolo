using Godot;
using System;
using SuperMarigolo.Scripts.Sounds;

public partial class RetryButton : Button
{
	public void _on_retry_button_pressed()
	{
		//TODO
		GetTree().ChangeSceneToFile("res://PlayingScene/FirstScene.tscn");
	}
}
