using Godot;
using System;

public partial class Head : Sprite2D
{
	private static Timer _timer;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_timer = GetNode<Timer>("Timer");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public static void startTimer()
	{
		_timer.Start(8.5f);
		GD.Print("Timer started");
	}
	
	public void _on_timer_timeout()
	{
		_timer.Stop();
		GD.Print("Timer stopped");
		GetTree().Quit();
	}
}
