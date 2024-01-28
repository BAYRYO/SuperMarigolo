using Godot;
using System;

public partial class Falling : Area2D
{
	public void _on_body_entered(CharacterBody2D body)
	{
		GetTree().ChangeSceneToFile("res://Interfaces/GameOverMenu/Gameover.tscn");
	}
}
