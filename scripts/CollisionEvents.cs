using Godot;
namespace PITHKT23.scripts;

public partial class CollisionEvents : Area2D
{
	private PITHKT23.scripts.SceneModifiers _sceneModifiers;
	private PITHKT23.scripts.GameManager _gameManager;
	private void OnSpikesBodyEntered(CollisionObject2D body)
	{
		_sceneModifiers = GetNode<SceneModifiers>("/root/world/scene_modifiers");
		if (body is not CharacterBody2D || _sceneModifiers.CollisionModifier == true) return;
		GD.Print("Game over.");
		GetTree().ChangeSceneToPacked(ResourceLoader.Load<PackedScene>(GetTree().CurrentScene.SceneFilePath));
	}

	private void OnPlatformBodyEntered(CollisionObject2D body)
	{
		_sceneModifiers = GetNode<SceneModifiers>("/root/world/scene_modifiers");
		if (body is not CharacterBody2D || _sceneModifiers.CollisionModifier == false) return;
		GD.Print("Game over.");
		GetTree().ChangeSceneToPacked(ResourceLoader.Load<PackedScene>(GetTree().CurrentScene.SceneFilePath));
	}

	private void OnExitBodyEntered(CollisionObject2D body)
	{
		if (body is not CharacterBody2D) return;
		_gameManager = GetNode<PITHKT23.scripts.GameManager>("/root/GameManager");
		_gameManager.LoadNextScene();
	}
}