using UnityEngine;
public class FruitTrader : Trader
{
    [SerializeField] private Fruits _fruit;

    protected override void Trade(ICanTrade character, string message, int cost)
    {
        string fruit = _fruit == Fruits.Apple ? "Яблоко" : _fruit == Fruits.Orange ? "Апельсин" : "Банан";

        character.Trade($"{message} {fruit}. Потрачено {cost} денег.", cost);
    }
}
