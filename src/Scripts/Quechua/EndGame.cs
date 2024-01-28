using Godot;
using System;

public partial class EndGame : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void _on_body_entered(CharacterBody2D characterBody2D)
	{
		GetTree().ChangeSceneToFile("res://PlayingScene/EndingScene.tscn");
	}
}
