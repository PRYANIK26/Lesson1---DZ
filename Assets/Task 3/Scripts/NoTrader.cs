public class NoTrader : Trader
{
    protected override void Trade(ICanTrade character, string message, int cost)
    {
        print(message);
    }
}
