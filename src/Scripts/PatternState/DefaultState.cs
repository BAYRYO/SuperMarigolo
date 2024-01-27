namespace SuperMarigolo.Scripts.PatternState;

public class DefaultState : State
{
    public State doState(Player player)
    {
        player.changeSpeed(300f);
        player.changeGravity(1000f);
        return player.DefaultState;
    }
    
    
}