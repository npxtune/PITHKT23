using Godot;
namespace PITHKT23.scripts;

public partial class CollisionEvents : Area2D
{
	private void OnSpikesBodyEntered(PhysicsBody2D body)
	{
		GD.Print("collided with area");
	}
}