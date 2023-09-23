using Godot;

namespace PITHKT23.scripts;

public partial class LevelMovement : CharacterBody2D
{
	private const float Speed = 170.0f;
	
	// Get the gravity from the project settings to be synced with RigidBody nodes.
	

	public override void _PhysicsProcess(double delta)
	{
		MoveLevel(delta);
	}
	
	

	public void MoveLevel(double delta)
	{
		
		Vector2 Move = new Vector2();
		Move = Input.GetVector("move_left", "move_right", "move_up", "move_down");
		
		GlobalPosition += Move * Speed * (float)delta;
	}
}