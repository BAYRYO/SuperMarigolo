using Godot;
using System;

public partial class TrapRocket : Area2D
{
	private AnimationPlayer _animation;
	public override void _Ready()
	{
		_animation = GetNode<AnimationPlayer>("TrapAnimation");
	}

	public void _on_body_entered(CharacterBody2D body2D)
	{
		_animation.Play("rocket");
		Rocket.Train.Play();
	}
}
