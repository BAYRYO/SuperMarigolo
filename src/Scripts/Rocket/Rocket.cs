using Godot;
using System;
using SuperMarigolo.Scripts.GameOverMenu;

public partial class Rocket : Area2D
{
	public static AudioStreamPlayer2D Train;
	public override void _Ready()
	{
		Train = GetNode<AudioStreamPlayer2D>("AudioStreamPlayer2D");
	}

	public void _on_body_entered(CharacterBody2D body)
	{
        GameOverMenu.SetIndex(1);
		GetTree().ChangeSceneToFile("res://Interfaces/GameOverMenu/Gameover.tscn");
	}
}
