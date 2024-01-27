using Godot;
using System;
using SuperMarigolo.Scripts.PatternState;

public partial class Player : CharacterBody2D
{
	private String _current_state_name;
	private State _current_state = new DefaultState();

	public DefaultState DefaultState = new DefaultState();
	public GiantState GiantState = new GiantState();
	public StarState StarState = new StarState();
	
	private float Speed = 300.0f;
	private float JumpVelocity = -20.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	private float _gravity = 1000f;

	public override void _PhysicsProcess(double delta)
	{
		_current_state.doState(this);
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += _gravity * (float)delta;

		// Handle Jump.
		if (Input.IsActionJustPressed("jump") && IsOnFloor())
			velocity.Y = JumpVelocity*1.7f;

		Vector2 direction = Input.GetVector("move_left", "move_right", "jump", "move_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}
		Velocity = velocity;
		MoveAndSlide();
	}
	
	public void changeSpeed(float speed)
	{
		Speed = speed;
	}
	
	public void changeJumpVelocity(float jumpVelocity)
	{
		JumpVelocity = jumpVelocity;
	}
}
