using Godot;
using System;

public partial class KillMonster : Area2D
{
	private CharacterBody2D _character;
	public override void _Ready()
	{
		_character = GetNode<CharacterBody2D>("../../RicardMan");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_body_entered()
	{
		_character.Visible = false;
	}
}
