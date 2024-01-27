using Godot;
using System;

public partial class RetryButton : Button
{
	public void _on_retry_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://PlayingScene/FirstScene.tscn");
	}
}
