using Godot;
namespace PITHKT23.scripts;

public partial class player_movement : CharacterBody2D
{
	private const float Speed = 300.0f;
	private float _jumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	private float _gravity;
	private Vector2 _direction;
	private bool _hasJumped;
	private scene_modifiers _sceneModifiers;

	public override void _PhysicsProcess(double delta)
	{
		_sceneModifiers = GetNode<scene_modifiers>("/root/world/scene_modifiers");
		_gravity = _sceneModifiers.GravityModifier;
		_jumpVelocity = _sceneModifiers.JumpModifier;
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += _gravity * (float)delta;

		// Handle Jump.
		if (Input.IsActionJustReleased("jump") && IsOnFloor())
		{
			velocity.Y = _jumpVelocity;
			_hasJumped = true;
		}
		else
		{
			_hasJumped = false;
		}

		if (IsOnFloor())
		{
			_direction = Input.GetVector("move_left", "move_right", "ui_up", "ui_down");
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}

		if (_hasJumped)
		{
			if (_direction != Vector2.Zero)
			{
				velocity.X = _direction.X * Speed;
			}
			else
			{
				velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			}
		}
		Velocity = velocity;
		GD.Print(velocity.X + "\t" + velocity.Y + "\t" + _gravity);
		MoveAndSlide();
	}
}