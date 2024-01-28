using Godot;
using System;
using SuperMarigolo.Scripts.Sounds;

public partial class GameOverSound : CanvasLayer
{
	private AudioStreamPlayer _music;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		BackgroundMusic.StopMusic();
		_music = GetNode<AudioStreamPlayer>("AudioStreamPlayer");
		_music.Play();
	}
}
