using Godot;
using System;

public partial class DeathAreaMush : Area2D
{
	private static Player _player;
	private static Sprite2D _sprite2DHead;
	private static AnimationPlayer _animationPlayerHead;
	private static CollisionShape2D _collisionShape2D;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_player = GetNode<Player>("../../Player");
		_animationPlayerHead = GetNode<AnimationPlayer>("../../Player/Head/AnimationPlayer");
		_sprite2DHead = GetNode<Sprite2D>("../../Player/Head");
		_sprite2DHead.Visible = false;
		_collisionShape2D = GetNode<CollisionShape2D>("CollisionShape2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void _on_body_entered(Node body)
	{
		if (body.IsInGroup("dead"))
		{
			Head.startTimer();
			_player.changeState(new GiantState());
			_sprite2DHead.Visible = true;
			_animationPlayerHead.Play("biggerHead");
		}
		
	}
}
