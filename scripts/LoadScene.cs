using Godot;
using System;

public partial class LoadScene : Button
{
	private GameManager _gameManager;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_gameManager = GetNode<GameManager>("/root/GameManagerDev/GM-Node");
		GD.Print("fuuuck");
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void OnButtonPressed()
	{
		GD.Print("button pressed");
		_gameManager._LoadNextScene();
		
	}
}
