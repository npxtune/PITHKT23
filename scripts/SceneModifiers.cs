using Godot;
namespace PITHKT23.scripts;

public partial class SceneModifiers : Node
{
    [ExportGroup("Modifiers")]
    [Export] public float GravityModifier = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
    [Export] public float JumpModifier = -400.0f;
    [Export] public bool CollisionModifier = false;
    [Export] public bool Move_Level = false;
    [Export] public bool Invert_Flip = false;
    
    private float baseGravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
    private float baseJump = -400.0f;
    private float flipGravity = 1.0f;
    
    private bool flipped;
    
    public override void _Process(double delta)
    {
        //Getting data from Sliders and Buttons
        Godot.Range G_Slider_Range = GetNode<Godot.Range>("Gravity-Slider");
        Godot.Range J_Slider_Range = GetNode<Godot.Range>("Jump-Slider");
        BaseButton InvertSpikes_Button = GetNode<BaseButton>("InvertSpikes");
        BaseButton Move_Level_Button = GetNode<BaseButton>("Move_Level");
        BaseButton Invert_Flip_Button = GetNode<BaseButton>("Invert_Flip");
        GravityModifier = baseGravity  * (float)((G_Slider_Range.Value) / 50) * flipGravity;
        JumpModifier = baseJump  * (float)((J_Slider_Range.Value) / 50);
        Move_Level = InvertSpikes_Button.ButtonPressed;
        Invert_Flip = InvertSpikes_Button.ButtonPressed;
        CollisionModifier = InvertSpikes_Button.ButtonPressed;
    
    
        var Camera = GetNode<Node2D>("Camera2D");
        Camera.Transform.RotatedLocal(1);
    
        if (Input.IsKeyPressed(Key.C))
        {
            GD.Print("Flip");
            InvertFlip();
        }
    }
    
    private void InvertFlip()
    {
        var Player = GetNode("CharacterBody2D");
        var  Camera = GetNode<Node2D>("Camera2D");
        RayCast2D raycast = GetNode<RayCast2D>("CharacterBody2D/InverCast");
    
    
        if (Invert_Flip)
        {
            Camera.Transform.RotatedLocal(180);
            flipGravity = -1.0f;
        }
        else
        {
            flipGravity = 1.0f;
        }
    }
}