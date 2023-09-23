using Godot;
namespace PITHKT23.scripts;

public partial class LoadScene : Button
{
	private PITHKT23.scripts.GameManager _gameManager;
	public override void _Ready()
	{
		_gameManager = GetNode<PITHKT23.scripts.GameManager>("/root/Node2D/GM-Node");
		GD.Print("LoadScene script initialized");
		
	}
	
	private void OnButtonPressed()
	{
		GD.Print("button pressed");
		_gameManager.LoadNextScene();
		
	}
}