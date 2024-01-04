using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public void AddScore()
    {
        ++score;
    }

    private void OnEnable()
    {
        Calculator.BlockPlaced += AddScore;
    }

    private void OnDisable()
    {
        Calculator.BlockPlaced -= AddScore;
    }
}
