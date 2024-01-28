using Godot;
using System;

public partial class TrapTchomp : Area2D
{
	private AnimationPlayer _animation;
	public override void _Ready()
	{
		_animation = GetNode<AnimationPlayer>("TrapAnimation");
	}

	public void _on_body_entered(CharacterBody2D body2D)
	{
		_animation.Play("Tchomp");
		Tchomp.Scream.Play();
	}
}
