using Godot;
using System;

public partial class Koopa : CharacterBody2D
{
	public const float Speed = 150.0f;
	public const float JumpVelocity = -400.0f;

	private float LastPosition;
	private float currentPosition;
	private int _padding =1;
	private AnimationPlayer _characterBody;

	public override void _Ready()
	{
		base._Ready();
		LastPosition = GlobalPosition.X;
		_characterBody = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	

	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _Process(double delta)
	{
		//_characterBody.Play("Koopa");
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
