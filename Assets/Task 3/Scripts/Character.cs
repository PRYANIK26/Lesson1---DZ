using System;
using UnityEngine;

public class Character : MonoBehaviour, ICanTrade
{
    [SerializeField] private int _startCoins;
    public int Coins {get; private set;}


    private void Start()
    {
        Coins = _startCoins;
    }

    public void Trade(string tradeMessage, int cost)
    {
        Coins -= cost;
        print(tradeMessage);
        print($"Осталось {Coins} денег" );
    }
}
