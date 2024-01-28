using Godot;
using System;

public partial class EndingScene : Node
{
	private AnimationPlayer _anime;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_anime = GetNode<AnimationPlayer>("AnimationPlayer");
		_anime.Play("Ending_scene");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
