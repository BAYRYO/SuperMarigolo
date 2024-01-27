using Godot;
using System;

public partial class ParallaxBackground : Godot.ParallaxBackground
{
	private float _scroll_speed = 500.0f; 
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		ScrollOffset = ScrollOffset with { X = _scroll_speed };
	}
}
