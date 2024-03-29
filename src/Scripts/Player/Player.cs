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
	private float JumpVelocity = -80.0f;

	private AnimationPlayer _characterHeadAnimation;
	private AnimationPlayer _characterBody;

	private AnimatedSprite2D _bodyAnimated;
	private Sprite2D _head;
	// Get the gravity from the project settings to be synced with RigidBody nodes.
	private float _gravity =  ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
	
	private AudioStreamPlayer2D _jumpSFX; 
	public override void _Ready()
	{
		GD.Print("Je suis dan sle rdy");
		_characterHeadAnimation = GetNode<AnimationPlayer>("Head/AnimationPlayer");
		GD.Print("1");
		_characterBody = GetNode<AnimationPlayer>("AnimationPlayer");
		GD.Print("2");
		_bodyAnimated = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		GD.Print("3");
		_head = GetNode<Sprite2D>("Head");
		GD.Print("4");
	}

	public override void _PhysicsProcess(double delta)
	{
		_current_state.doState(this);
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += _gravity * (float)delta;
			

		// Handle Jump.
		if (Input.IsActionJustPressed("jump") && IsOnFloor())
		{
			_bodyAnimated.Stop();
			velocity.Y = JumpVelocity*10f;
			_characterBody.Play("jump");
			_bodyAnimated.Play("jump");
		}
			
			

		Vector2 direction = Input.GetVector("move_left", "move_right", "jump", "move_down");
		if (direction != Vector2.Zero)
		{
			if (Input.IsActionPressed("move_right"))
			{
				_bodyAnimated.FlipH = false;
				_head.FlipH = false;
				_bodyAnimated.Play("move");
			}
			else if (Input.IsActionPressed("move_left"))
			{
				_bodyAnimated.FlipH = true;
				_head.FlipH = true;
				_bodyAnimated.Play("move");
			}
			
			
			else
			{
				
				_bodyAnimated.Play("default");
			}
			
			Input.ActionPress("move_down");
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
	
	public void changeGravity(float gravity)
	{
		_gravity = gravity;
	}
	
	public void changeState(State state)
	{
		_current_state = state;
	}
	
	public AnimationPlayer getCharacterHead()
	{
		return _characterHeadAnimation;
	}
}
