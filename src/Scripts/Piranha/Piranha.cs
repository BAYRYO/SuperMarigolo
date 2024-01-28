using Godot;
using System;

public partial class Piranha : Node2D
{
	private AnimationPlayer _characterBody;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_characterBody = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//_characterBody.Play("Piranha");
	}
}
