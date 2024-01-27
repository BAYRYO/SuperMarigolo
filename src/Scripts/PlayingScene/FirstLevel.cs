using Godot;
using System;

public partial class FirstLevel : Control
{
    private static Camera2D _camera;
    public override void _Ready()
    {
	    base._Ready();
	    
    }

    public void _on_tree_entered()
	{
		_camera = GetNode<Camera2D>("Player/Camera2D");
		_camera.Enabled = true;
		
	}

	public void _on_tree_exited()
	{
		_camera.Enabled = false;
	}
}
