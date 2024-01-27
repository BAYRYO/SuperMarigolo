using Godot;
using System;

public partial class Goomba : CharacterBody2D
{
	public const float Speed = 150.0f;
	public const float JumpVelocity = -400.0f;
	private float _lastPosition;
	private int _padding = 1; 

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;
		
		velocity.X = 1 * Speed;
	}

	public override void _Process(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;

		if (IsOnWall())
		{
			_padding = -_padding;
		}
		velocity.X = _padding * Speed;

		Velocity = velocity;
		MoveAndSlide();

	}
	
	
}
