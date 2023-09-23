using System.Transactions;
using Godot;
namespace PITHKT23.scripts;

public partial class GameManager : Node
{ 
	private static int _nextScene;
	// private void ReloadScene()
	// {
	// 	var reloadScene = Globals.listCounter;
	// 	var sceneToLoad = Globals.scenes[reloadScene];
	// 	var scene = ResourceLoader.Load<PackedScene>("res://scenes/" + sceneToLoad + ".tscn");
	// 	GetTree().ChangeSceneToFile("res://scenes/" + sceneToLoad + ".tscn");
	// }

	public void LoadNextScene(int loadSceneIndex = -1)
	{
		var currentScene = GetTree().CurrentScene;
		if (loadSceneIndex == -1)
		{
			_nextScene =  Globals.ListCounter + 1; 
		}
		else
		{
			_nextScene = loadSceneIndex; 
		}
		if (Globals.Scenes.Count == Globals.ListCounter + 1)
		{
			_allLevelCompleted();
			return;
		}
		Globals.ListCounter = _nextScene;
		var sceneToLoad = Globals.Scenes[_nextScene];
		GD.Print(sceneToLoad);
		var scene = ResourceLoader.Load<PackedScene>("res://scenes/" + sceneToLoad + ".tscn").Instantiate();
		GetTree().Root.AddChild(scene);
		GetTree().Root.RemoveChild(currentScene);
	}

	private static void _allLevelCompleted()
	{
		GD.Print("All level completed");
	}
}