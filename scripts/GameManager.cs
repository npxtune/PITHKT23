using Godot;
using System;
using System.Linq;

public partial class GameManager : Node
{
	// Called when the node enters the scene tree for the first time.
	private static int _nextScene;
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public void _Process(double delta)
	{
		GD.Print("fuuuuck");
	}

	public void _ReloadScene()
	{
		var reloadScene = Globals.listCounter;
		var sceneToLoad = Globals.scenes[reloadScene];
		PackedScene scene = GD.Load<PackedScene>("res://scenes/" + sceneToLoad + ".tscn");
		GetTree().ChangeSceneToFile("res://scenes/" + sceneToLoad + ".tscn");
	}

	public void _LoadNextScene(int indexofScenetoLoad = -1)
	{
		if (indexofScenetoLoad == -1)
		{
			_nextScene =  Globals.listCounter + 1; 
		}
		else
		{
			_nextScene = indexofScenetoLoad; 
		}
		if (Globals.scenes.Count == Globals.listCounter + 1)
		{
			_allLevelCompleted();
			return;
		}
		Globals.listCounter = _nextScene;
		var sceneToLoad = Globals.scenes[_nextScene];
		GD.Print(sceneToLoad);
		PackedScene scene = GD.Load<PackedScene>("res://scenes/" + sceneToLoad + ".tscn");
		GetTree().ChangeSceneToPacked(scene);
		
		//PackedScene scene = GD.Load<PackedScene>("res://scenes/" + sceneToLoad + ".tscn");
		//GetTree().ChangeSceneToFile("res://scenes/" + sceneToLoad + ".tscn");
		//var next_level_resource = LoadScene("res://scenes/" + sceneToLoad + ".tscn");
		//GetTree().ChangeSceneToFile("res://scenes/" + sceneToLoad + ".tscn");

		// Changing does not work



	}

	public void _allLevelCompleted()
	{
		GD.Print("All level completed");
	}
}


