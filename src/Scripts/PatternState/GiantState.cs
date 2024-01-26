namespace SuperMarigolo.Scripts.PatternState;

public class GiantState: State
{
    public State doState(Player player)
    {
        player.changeJumpVelocity(-200f);
        return player.GiantState;
    }
    
}