using Godot;
namespace PITHKT23.scripts;

public partial class Player : CharacterBody2D
{
	private const float Speed = 300.0f;
	private const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	private float _gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
	private Vector2 _direction;
	private bool _hasJumped;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += _gravity * (float)delta;

		// Handle Jump.
		if (Input.IsActionJustReleased("jump") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
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
		GD.Print(velocity.X + "\t" + velocity.Y);
		MoveAndSlide();
	}
}