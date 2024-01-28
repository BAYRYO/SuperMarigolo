using Godot;
using System;

public partial class RicardMan : CharacterBody2D
{
	public const float Speed = 100.0f;
	public const float JumpVelocity = -400.0f;
	private Sprite2D _sprite;
	private AnimationPlayer _animationPlayer;
	
	private int _padding = 1;
	
	private static bool canMove = false;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public RicardMan(Sprite2D sprite, AnimationPlayer animationPlayer)
	{
		_sprite = sprite;
		_animationPlayer = animationPlayer;
	}

	public RicardMan()
	{
		
	}

	public override void _Ready()
	{
		canMove = false;
	}

	public override void _Process(double delta)
	{
		if (canMove)
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
		

	public void spawn()
	{
		_animationPlayer.Play("spawn");
	}
	
	public void changeValueOfCanMove()
	{
		canMove = true;
	}
}
