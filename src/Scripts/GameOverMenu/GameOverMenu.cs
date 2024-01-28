using Godot;

namespace SuperMarigolo.Scripts.GameOverMenu;

public partial class GameOverMenu : Node
{
	public static int _index;
	private Label _label;
	private readonly string[] _text =
	{
		"Bah alors on a pris la grosse tete ?",
		"Tchou Tchou !",
		"AAAAAAAAAAAAAAAAAAAAAAAAAAH !",
		"text4",
	};
	public override void _Ready()
	{
		base._Ready();
		_label = GetNode<Label>("CanvasLayer/Control/CenterContainer/PanelContainer/VBoxContainer/Text");
		Reload();
	}
	private void Reload()
	{
		_label.Text = _text[_index];
	}
	public static void SetIndex(int index)
	{
		_index = index;
	}
}