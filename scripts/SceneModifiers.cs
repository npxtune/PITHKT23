using Godot;
namespace PITHKT23.scripts;

public partial class SceneModifiers : Node
{
    [ExportGroup("Modifiers")]
    [Export] public float GravityModifier = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
    [Export] public float JumpModifier = -400.0f;
    [Export] public bool CollisionModifier = false;
    [Export] public bool MoveLevelModifier = false;
    
    // public override void _Process(double delta)
    // {
    //     //Getting data from Sliders and Buttons
    //     Godot.Range G_Slider_Range = GetNode<Godot.Range>("Gravity-Slider");
    //     Godot.Range J_Slider_Range = GetNode<Godot.Range>("Jump-Slider");
    //     BaseButton InvertSpikes_Button = GetNode<BaseButton>("InvertSpikes");
    //     BaseButton Move_Level_Button = GetNode<BaseButton>("Move_Level");
    //     BaseButton Invert_Flip_Button = GetNode<BaseButton>("Invert_Flip");
    //     GravityModifier = baseGravity  * (float)((G_Slider_Range.Value) / 50) * flipGravity;
    //     JumpModifier = baseJump  * (float)((J_Slider_Range.Value) / 50);
    //     Move_Level = InvertSpikes_Button.ButtonPressed;
    //     Invert_Flip = InvertSpikes_Button.ButtonPressed;
    //     CollisionModifier = InvertSpikes_Button.ButtonPressed;
    // }

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