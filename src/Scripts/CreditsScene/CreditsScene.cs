using System;
using Godot;
namespace SuperMarigolo.Scripts.CreditsScene;

public partial class CreditsScene : Control
{
    private VBoxContainer _vBoxContainer;
    private const float Speed = 6f;
    private Vector2I _screenSize;
    private AnimatedSprite2D _animateSprite;
    private RichTextLabel _label;
    private CenterContainer _centerContainer;
    private PanelContainer _panelContainer;
    private int _index;
    private CharacterBody2D _player;
    private AnimationPlayer _animationLabel;
    private const string BLUE = "[color=deepskyblue]";
    private const string YELLOW = "[color=gold]";
    private const string RED = "[color=crimson]";
    private const string GREEN = "[color=mediumseagreen]";
    private readonly string[][] _text = 
    {
        new[]
        {
            "[font_size=100][center]"+BLUE+"M"+YELLOW+"e"+RED+"m"+GREEN+"b"+YELLOW+"r"+RED+"e"+GREEN+"s "+BLUE+"d"+GREEN+"e "+YELLOW+"l"+RED+"'"+GREEN+"e"+YELLOW+"q"+RED+"u"+GREEN+"i"+YELLOW+"p"+BLUE+"e\n",
            "[font_size=60]"+BLUE+"A"+YELLOW+"l"+RED+"e"+GREEN+"x"+YELLOW+"a"+RED+"n"+GREEN+"d"+YELLOW+"r"+BLUE+"e "+GREEN+"B"+YELLOW+"i"+RED+"l"+GREEN+"l"+YELLOW+"o"+RED+"n"+GREEN+"n"+YELLOW+"e"+BLUE+"t\n",
            BLUE+"L"+YELLOW+"u"+RED+"c"+BLUE+"a"+YELLOW+"s"+RED+" T"+GREEN+"h"+YELLOW+"e"+BLUE+"o"+GREEN+"d"+YELLOW+"o"+RED+"r"+GREEN+"e\n",
            BLUE+"M"+YELLOW+"a"+RED+"t"+BLUE+"i"+YELLOW+"a"+RED+"s "+GREEN+"D"+YELLOW+"e"+BLUE+"v"+GREEN+"e"+YELLOW+"z"+RED+"e\n",
            BLUE+"L"+YELLOW+"o"+RED+"g"+BLUE+"a"+YELLOW+"n "+RED+"F"+GREEN+"e"+YELLOW+"r"+BLUE+"r"+GREEN+"e"+YELLOW+"i"+RED+"r"+GREEN+"a\n",
            BLUE+"L"+YELLOW+"e"+RED+"a "+BLUE+"V"+YELLOW+"e"+RED+"r"+GREEN+"d"+YELLOW+"e"+BLUE+"l"+GREEN+"e"+YELLOW+"t\n",
            BLUE+"M"+YELLOW+"a"+RED+"e"+BLUE+"l"+YELLOW+"y"+RED+"s "+GREEN+"T"+YELLOW+"o"+BLUE+"u"+GREEN+"s"+YELLOW+"s"+RED+"a"+YELLOW+"i"+RED+"n"+GREEN+"t"
        },
        new []
        {
            "[center][font_size=100]"+BLUE+"S"+YELLOW+"u"+RED+"p"+GREEN+"e"+YELLOW+"r "+RED+"M"+GREEN+"a"+BLUE+"r"+GREEN+"i"+YELLOW+"g"+RED+"o"+GREEN+"l"+YELLOW+"o\n",
            "[font_size=60]"+BLUE+"M"+YELLOW+"e"+RED+"r"+GREEN+"c"+YELLOW+"i "+RED+"d"+GREEN+"'"+BLUE+"a"+GREEN+"v"+YELLOW+"o"+RED+"i"+GREEN+"r "+YELLOW+"j"+RED+"o"+GREEN+"u"+YELLOW+"e"+BLUE+" !"
        }
    };
    
    public override void _Ready()
    {
        base._Ready();
        _centerContainer = GetNode<CenterContainer>("CenterContainer");
        _panelContainer = _centerContainer.GetNode<PanelContainer>("PanelContainer");
        _vBoxContainer = _panelContainer.GetNode<VBoxContainer>("VBoxContainer");
        _player = GetNode<CharacterBody2D>("Player");
        _screenSize = DisplayServer.WindowGetSize();
        _animateSprite = _player.GetNode<AnimatedSprite2D>("AnimatedSprite2D");
        _label = _vBoxContainer.GetNode<RichTextLabel>("RichTextLabel");
        _animationLabel = _label.GetNode<AnimationPlayer>("AnimationPlayer");
        ResetPlayerResetPosition();
    }

    public override void _PhysicsProcess(double d)
    {
        var velocity = new Vector2
        {
            X = Speed
        };
        _animateSprite.Play("move");
        _player.MoveAndCollide(velocity);
        if (_player.Position.X > _screenSize.X * 1.05)
        {
            ResetPlayerResetPosition();
        }
    }

    private void ResetPlayerResetPosition()
    {
        if (_index == 2)
        {
            GetTree().ChangeSceneToFile("res://Interfaces/Menu/MainMenu.tscn");
            return;
        }
        ReloadLabel(_index);
        _index += 1;
        _player.Position = new Vector2((float)Math.Round(_screenSize.X * -0.05), (int)Math.Round(_screenSize.Y * 0.95));
    }
    
    private void ReloadLabel(int index)
    {
        _label.Clear();
        foreach (var j in _text[index])
        {
            _label.AppendText(j);
        }
        _animationLabel.Play("reset");
    }
}