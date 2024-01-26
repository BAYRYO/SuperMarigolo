namespace SuperMarigolo.Scripts.PatternState;

public class DefaultState : State
{
    public State doState(Player player)
    {
        player.changeSpeed(300f);
        player.changeJumpVelocity(-400f);
        return player.DefaultState;
    }
    
    
}