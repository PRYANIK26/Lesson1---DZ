using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BallContainer : MonoBehaviour
{
    [SerializeField] private GameRules _gameRules;
    private List<Ball> _allBalls;
    private int _redCount;
    private int _greenCount;
    private int _whiteCount;
    private void Awake()
    {
        _allBalls = FindObjectsOfType<Ball>().ToList();

        foreach (var ball in _allBalls)
        {
            SetBallsCount(ball, 1);
        }
    }

    void SetBallsCount(Ball ball, int value)
    {
        if (ball.BallType == BallType.Red)
            _redCount += value;
        else if (ball.BallType == BallType.Green)
            _greenCount += value;
        else if (ball.BallType == BallType.White) _whiteCount += value;
    }

    public void OnBallClick(Ball ball)
    {
        SetBallsCount(ball, -1);
        
        _allBalls.Remove(ball);
        Destroy(ball.gameObject);

        CheckWin();
    }

    void CheckWin()
    {
        if (_gameRules == GameRules.AllBalls)
        {
            if (_allBalls.Count == 0)
                print("Выиграл! Все шары уничтожены");
        }
        else if (_gameRules == GameRules.OneColorBalls)
        {
            if (_greenCount == 0 || _redCount == 0 || _whiteCount == 0)
                print("Выиграл! Шары одного цвета уничтожены");
        }
    }
}
