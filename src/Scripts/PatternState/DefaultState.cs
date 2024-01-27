namespace SuperMarigolo.Scripts.PatternState;

public class DefaultState : State
{
    public State doState(Player player)
    {
        player.changeSpeed(300f);
        player.changeGravity(3000f);
        return player.DefaultState;
    }
    
    
}