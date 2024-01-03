using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    private void Start()
    {
        playerData = SaveSystem.LoadPlayerData();
    }
}
