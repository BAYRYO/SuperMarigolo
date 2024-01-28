using Godot;
using System;
using SuperMarigolo.Scripts.GameOverMenu;

public partial class DeathArea : Area2D
{
	private static Player _player;
	private static Sprite2D _sprite2DHead;
	private static AnimationPlayer _animationPlayerHead;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_player = GetNode<Player>("../../Player");
		_animationPlayerHead = GetNode<AnimationPlayer>("../../Player/Head/AnimationPlayer");
		_sprite2DHead = GetNode<Sprite2D>("../../Player/Head");
		_sprite2DHead.Visible = false;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void _on_body_entered(Node body)
	{
		GD.Print("KDZBduhqzdzqdn");
		if (body.IsInGroup("dead"))
		{
			GameOverMenu.SetIndex(3);
			GetTree().ChangeSceneToFile("res://Interfaces/GameOverMenu/Gameover.tscn");
		}
		
	}
}
