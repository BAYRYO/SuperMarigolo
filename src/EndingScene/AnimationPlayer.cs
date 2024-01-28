using Godot;
using System;

public partial class AnimationPlayer : Godot.AnimationPlayer
{
	public void _on_animation_finished(String anime)
	{
		GetTree().ChangeSceneToFile("res://Interfaces/Credits/CreditsScene.tscn");
	}
}
