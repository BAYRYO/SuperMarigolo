using Godot;
using System;
using SuperMarigolo.Scripts.PatternState;

public partial class Area2D : Godot.Area2D
{
	private Player _player;
	private AnimationPlayer _characterHead;

	private Sprite2D _head;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_player = GetNode<Player>("../../Player");
		_characterHead = GetNode<AnimationPlayer>("../../Player/Head/AnimationPlayer");
        _head = GetNode<Sprite2D>("../../Player/Head");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void _on_body_entered(Player player)
	{
		_head.Visible = true;
		player.changeState(new GiantState());
		_characterHead = player.getCharacterHead();
		_characterHead.Play("biggerHead");
		Head.startTimer();
	}
}
