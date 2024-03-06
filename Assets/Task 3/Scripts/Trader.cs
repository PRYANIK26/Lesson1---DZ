using UnityEngine;

public abstract class Trader : MonoBehaviour
{
    [SerializeField] private int _cost;
    [SerializeField] private string _tradeMessage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out ICanTrade character))
        {
            if (character.Coins < _cost)
            {
                Debug.Log("У тебя нет денег!");
                return;
            }
            Trade(character, _tradeMessage, _cost);
        }
    }
    protected abstract void Trade(ICanTrade character, string message, int cost);
}
