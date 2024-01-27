using Godot;
using System;

public partial class TransitionScene : CanvasLayer
{
	private static AnimationPlayer _transition;


	public override void _Ready() {
		_transition = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	public int changeScene(String scenePath)
	{
		try
		{
			_transition.Play("dissolve");
			//Success code
			return 0;
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			return 1;
		}
		
		
		
	}
	
	public AnimationPlayer getTransition()
	{
		return _transition;
	}
}
