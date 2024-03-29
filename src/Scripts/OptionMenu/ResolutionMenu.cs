using Godot;

namespace SuperMarigolo.Scripts.OptionMenu;

public partial class ResolutionMenu : OptionButton
{
    private static readonly Vector2I[] Resolutions = new Vector2I[]
    {
        new Vector2I(1920, 1080),
        new Vector2I(1600, 900),
        new Vector2I(1280, 720)
    };

    private static readonly int CustomResolutionIndex = Resolutions.Length;

    public override void _Ready()
    {
        GetTree().Root.Connect("size_changed", new Callable(this, "_on_resized"));
    }

    private void _on_resolution_selected(int index)
    {
        switch (index)
        {
            case 0:
                DisplayServer.WindowSetSize(Resolutions[0]);
                GD.Print(Resolutions[0]);
                break;
            case 1:
                DisplayServer.WindowSetSize(Resolutions[1]);
                GD.Print(Resolutions[1]);
                break;
            case 2:
                DisplayServer.WindowSetSize(Resolutions[2]);
                GD.Print(Resolutions[2]);
                break;
            default:
                if (ItemCount == CustomResolutionIndex)
                    AddItem("Custom size", CustomResolutionIndex);
                if (DisplayServer.WindowGetSize() != Resolutions[0] &&
                    DisplayServer.WindowGetSize() != Resolutions[1] &&
                    DisplayServer.WindowGetSize() != Resolutions[2])
                {
                    Selected = CustomResolutionIndex;
                }
                else
                {
                    RemoveItem(CustomResolutionIndex);
                }
                break;
        }
    }
    private void _on_resized()
    {
        this.
            _on_resolution_selected(CustomResolutionIndex);
    }
}