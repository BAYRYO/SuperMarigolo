using Godot;
using System;

public partial class Goomba : CharacterBody2D
{
    public const float Speed = 150.0f;
    private float _lastPosition;
    private int _padding = 1;
    private AudioStreamPlayer2D _fart;


    // Get the gravity from the project settings to be synced with RigidBody nodes.
    public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

    public override void _Ready()
    {
        
        _fart = GetNode<AudioStreamPlayer2D>("AudioStreamPlayer2D");
    }


    public override void _Process(double delta)
    {
        Vector2 velocity = Velocity;

        // Add the gravity.
        if (!IsOnFloor())
            velocity.Y += gravity * (float)delta;

        if (IsOnWall())
        {
            _padding = -_padding;
            _fart.Play();
        }
        velocity.X = _padding * Speed;

        Velocity = velocity;
        MoveAndSlide();

        // Check if the audio is finished and restart if necessary.
        if (!_fart.Playing)
        {
            _fart.Play();
        }
    }
}