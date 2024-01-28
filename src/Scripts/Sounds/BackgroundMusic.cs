using Godot;

namespace SuperMarigolo.Scripts.Sounds;

public partial class BackgroundMusic : Node
{
	private static AudioStreamPlayer _backgroundMusic;
	private static float _seconds;

	private const string PathMusic = "Music";

	public override void _Ready()
	{
		_backgroundMusic = GetNode<AudioStreamPlayer>(PathMusic);
		_backgroundMusic.Autoplay = true;
	}

	public override void _Process(double delta)
	{
		_seconds = _backgroundMusic.GetPlaybackPosition();
	}

	public static void PlayMusic()
	{
		_backgroundMusic.Play(_seconds);
	}
		
	public static void StopMusic()
	{
		_backgroundMusic.Stop();
	}

	private void _on_music_finished()
	{
		_backgroundMusic.Play();
	}
}
