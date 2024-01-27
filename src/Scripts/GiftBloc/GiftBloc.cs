using Godot;
using System;

public partial class GiftBloc : Area2D
{
	private static RicardMan _ricardMan; 
	private AnimationPlayer _ricardManAnimation;
	private bool ricardManDidntSpawned = true;
	public override void _Ready()
	{
		_ricardManAnimation = GetNode<AnimationPlayer>("../RicardMan/AnimationPlayer");
		_ricardMan = new RicardMan(GetNode<Sprite2D>("../RicardMan/Sprite2D"), _ricardManAnimation);
	}
	public override void _Process(double delta)
	{
	}
	
	public async void _on_body_entered(Node body)
	{
		if (ricardManDidntSpawned)
		{
			GD.Print("je suis entré");
			_ricardManAnimation.Play("spawn");
			await ToSignal(_ricardManAnimation, "animation_finished");
			_ricardMan.changeValueOfCanMove();
			ricardManDidntSpawned = false;
		}
		
	}
}
