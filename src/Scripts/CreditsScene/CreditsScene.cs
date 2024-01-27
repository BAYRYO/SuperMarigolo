using System;
using Godot;

namespace SuperMarigolo.Scripts.CreditsScene;

public partial class CreditsScene : Control
{
    private VBoxContainer _vBoxContainer;
    private const float Speed = 6f;
    private Vector2I _screenSize;
    //private AnimatedSprite2D _animateSprite;
    private RichTextLabel _label;
    private TextureRect _textureRect;
    private CenterContainer _centerContainer;
    private PanelContainer _panelContainer;
    private int _index;
    private CharacterBody2D _characterBody2D;
    private AnimationPlayer _animationLabel;
    private readonly string[][] _text = 
    {
        new[]
        {
            "[font_size=70][center]Membres de l'équipe\n",
            "[font_size=40]Alexandre Billonnet\n",
            "Lucas Theodore\n",
            "Matias Deveze\n",
            "Logan Ferreira\n",
            "Léa "
        },
        new []
        {
            "[center][font_size=70]Super Marigolo\n",
            "[font_size=40]Merci d'avoir joué !"
        }
    };
    
    public override void _Ready()
    {
        base._Ready();
        _centerContainer = GetNode<CenterContainer>("CenterContainer");
        _panelContainer = _centerContainer.GetNode<PanelContainer>("PanelContainer");
        _vBoxContainer = _panelContainer.GetNode<VBoxContainer>("VBoxContainer");
        _characterBody2D = GetNode<CharacterBody2D>("Player");
        _screenSize = DisplayServer.WindowGetSize();
        //_animateSprite = _characterBody2D.GetNode<AnimatedSprite2D>("AnimatedSprite2D");
        _label = _vBoxContainer.GetNode<RichTextLabel>("RichTextLabel");
        _textureRect = _vBoxContainer.GetNode<TextureRect>("TextureRect");
        _animationLabel = _label.GetNode<AnimationPlayer>("AnimationPlayer");
        ResetPlayerResetPosition();
    }

    public override void _PhysicsProcess(double d)
    {
        var velocity = new Vector2
        {
            X = Speed
        };
        //_animateSprite.Play("moveRight");
        _characterBody2D.MoveAndCollide(velocity);
        if (_characterBody2D.Position.X > _screenSize.X * 1.05)
        {
            ResetPlayerResetPosition();
        }
    }

    private void ResetPlayerResetPosition()
    {
        if (_index == 3)
        {
            GetTree().ChangeSceneToFile("res://TitleScreen/TitleScreen.tscn");
            return;
        }
        ReloadLabel(_index);
        _index += 1;
        _characterBody2D.Position = new Vector2((float)Math.Round(_screenSize.X * -0.05), (int)Math.Round(_screenSize.Y * 0.95));
    }
    
    private void ReloadLabel(int index)
    {
        _label.Clear();
        foreach (var j in _text[index])
        {
            _label.AppendText(j);
            if (index is not 0)
            {
                _textureRect.Show();
            }
        }
        _animationLabel.Play("reset");
    }
}