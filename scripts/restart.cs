using Godot;
namespace PITHKT23.scripts;

public partial class restart : Node
{
	//	This is an example on how to restart the scene by Tim :)
	//	GetTree().CurrentScene.SceneFilePath -> Gets path of current scene in order to reload it
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("debug_restart"))
		{
			GD.Print("Reloading scene...");
			GetTree().ChangeSceneToFile(GetTree().CurrentScene.SceneFilePath);
		}
	}
}