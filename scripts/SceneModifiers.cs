using Godot;
namespace PITHKT23.scripts;

public partial class SceneModifiers : Node
{
    [ExportGroup("Modifiers")]
    [Export] public float GravityModifier = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
    [Export] public float JumpModifier = -400.0f;
    [Export] public bool CollisionModifier = false;
    [Export] public bool MoveLevelModifier = false;

    private void GravitySliderChanged(float value)
    {
        GD.Print(GravityModifier * (value / 50));
    }

    private void JumpSliderChanged(float value)
    {
        GD.Print(JumpModifier * (value / 50));
    }

    private void CollisionBoolChanged(bool isPressed)
    {
        // TODO button press
    }

    private void MoveLevelBoolChanged(bool isPressed)
    {
        // TODO button press + move level??
    }
}