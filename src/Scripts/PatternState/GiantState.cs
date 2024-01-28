
using SuperMarigolo.Scripts.GameOverMenu;

public class GiantState: State
{
    public State doState(Player player)
    {
        GameOverMenu.SetIndex(0);
        player.changeSpeed(150f);
        player.changeGravity(2000f);
        return player.GiantState;
    }
}