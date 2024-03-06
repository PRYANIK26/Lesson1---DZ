public class ArmorTrader : Trader
{
    protected override void Trade(ICanTrade character, string message, int cost)
    {
        character.Trade($"{message} Потрачено {cost} денег.", cost);
    }
}
