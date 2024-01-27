using Godot;
using System;

public partial class TransitionScene : CanvasLayer
{
	private AnimationPlayer _transition;

	public override void _Ready()
	{
		_transition = GetNode<AnimationPlayer>("AnimationPlayer");
		GD.Print(_transition);
	}

	public async void changeScene(String scenePath)
	{
		_transition.Play("dissolve");
		await ToSignal(_transition, "animation_finished");
		GetTree().ChangeSceneToFile(scenePath);
		_transition.PlayBackwards("dissolve");
	}
}
