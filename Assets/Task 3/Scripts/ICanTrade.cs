public interface ICanTrade
{
    int Coins { get; }
    void Trade(string tradeMessage, int cost);
}
