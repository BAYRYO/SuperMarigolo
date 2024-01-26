namespace SuperMarigolo.Scripts.PatternState;

public class StarState : State
{
    public State doState(Player player)
    {
        player.changeSpeed(1200f);
        player.changeJumpVelocity(-1200f);
        return player.StarState;
    }
}