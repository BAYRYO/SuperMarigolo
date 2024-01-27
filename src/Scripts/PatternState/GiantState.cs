using Godot;

namespace SuperMarigolo.Scripts.PatternState;

public class GiantState: State
{
    

    
    public State doState(Player player)
    {
        player.changeSpeed(150f);
        player.changeGravity(2000f);
        return player.GiantState;
    }
    
}