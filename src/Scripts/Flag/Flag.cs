using Godot;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

public partial class Flag : Area2D
{
	private AnimationPlayer _flagAnimation;
	private bool isAlreadyFelt = false;
	private CollisionShape2D _collisionShape2D;
	private CollisionShape2D _collisionShape2D2;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_flagAnimation = GetNode<AnimationPlayer>("AnimationPlayer");
		_collisionShape2D = GetNode<CollisionShape2D>("RigidBody2D/Flag");
		_collisionShape2D2 = GetNode<CollisionShape2D>("RigidBody2D/FlagSupport");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void _on_body_entered(CharacterBody2D characterBody2D)
	{
		CallDeferred("methodBodyEntered");
	}

	public void methodBodyEntered()
	{
		if (!isAlreadyFelt)
		{
			_flagAnimation.Play("fall");
			isAlreadyFelt = true;
			_collisionShape2D.Disabled = true;
			_collisionShape2D2.Disabled = true;
		}
	}
}
