public class GameManager : Singleton<GameManager>
{
    /// <summary>
    /// 
    /// Started: Game just started
    /// 
    /// </summary>
    public enum Signal
    {
        Started,
        Paused,
        SoftEnded,
        Ended
    }

    public static System.Action<Signal> GameSignal;
    public PlayerData playerData;

    public override void Awake()
    {
        base.Awake();
        name = nameof(GameManager);
        playerData = SaveSystem.LoadPlayerData();
    }
}
