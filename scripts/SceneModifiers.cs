using Godot;
namespace PITHKT23.scripts;

public partial class SceneModifiers : Node
{
    //  STANDARD VALUES DO NOT CHANGE!!!
    private const float Gravity = 980f;
    private const float Jump = -400f;
    
    [ExportGroup("Modifiers")]
    [Export] public float GravityModifier = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
    [Export] public float JumpModifier = -400.0f;
    [Export] public bool CollisionModifier = false;
    [Export] public bool MoveLevelModifier = false;

    private void GravitySliderChanged(float value)
    {
        GD.Print(GravityModifier * (value / 50));
        GravityModifier = Gravity * (value / 50);
    }

    private void JumpSliderChanged(float value)
    {
        GD.Print(JumpModifier * (value / 50));
        JumpModifier = Jump * (value / 50);
    }

    private void CollisionBoolChanged(bool isPressed)
    {
        GD.Print(isPressed);
        CollisionModifier = isPressed;
    }

    private void MoveLevelBoolChanged(bool isPressed)
    {
        GD.Print(isPressed);
        MoveLevelModifier = isPressed;
    }
}