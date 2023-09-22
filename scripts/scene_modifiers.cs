using Godot;
namespace PITHKT23.scripts;

public partial class scene_modifiers : Node
{
	[ExportGroup("Modifiers")]
	[Export]
	public float GravityModifier = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
	[Export]
	public float JumpModifier = -400.0f;
}