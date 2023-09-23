using Godot;
namespace PITHKT23.scripts;

public partial class CollisionEvents : Area2D
{
	private SceneModifiers _sceneModifiers;
	private void OnSpikesBodyEntered(CollisionObject2D body)
	{
		_sceneModifiers = GetNode<SceneModifiers>("/root/world/scene_modifiers");
		if (body is not CharacterBody2D || _sceneModifiers.CollisionModifier == true) return;
		GD.Print("Game over.");
		GetTree().ChangeSceneToFile(GetTree().CurrentScene.SceneFilePath);
	}

	private void OnPlatformBodyEntered(CollisionObject2D body)
	{
		_sceneModifiers = GetNode<SceneModifiers>("/root/world/scene_modifiers");
		if (body is not CharacterBody2D || _sceneModifiers.CollisionModifier == false) return;
		GD.Print("Game over.");
		GetTree().ChangeSceneToFile(GetTree().CurrentScene.SceneFilePath);
	}
}