using Godot;
using System;
using System.Diagnostics.Metrics;
using System.Linq;

public partial class GameManager : Node
{
	// Called when the node enters the scene tree for the first time.
	private static int _nextScene;
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public void _Process(double delta)
	{
	}

	public void _ReloadScene()
	{
		var reloadScene = Globals.listCounter;
		var sceneToLoad = Globals.scenes[reloadScene];
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
		GD.Print(GetTree().CurrentScene.SceneFilePath);
		String loadingStr = "res://scenes/" + sceneToLoad + ".tscn";
		GD.Print(loadingStr);

        PackedScene PackedToLoad = GD.Load<PackedScene>(loadingStr);


        /*
        GetTree().ChangeSceneToFile(loadingStr);
        GetTree().Free();
        GD.Print(GetTree().CurrentScene);
        GetTree().UnloadCurrentScene();
		*/



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


