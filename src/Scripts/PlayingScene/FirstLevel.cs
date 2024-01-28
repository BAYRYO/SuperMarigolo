using Godot;
using System;
using SuperMarigolo.Scripts.Sounds;

public partial class FirstLevel : Control
{
	private static Camera2D _camera;

	public void _on_tree_entered()
	{
		_camera = GetNode<Camera2D>("Player/Camera2D");
		_camera.Enabled = true;
		BackgroundMusic.PlayMusic();
		
	}

	public void _on_tree_exited()
	{
		_camera.Enabled = false;
	}
}
