using TMPro;
using UnityEngine;

public class GameplayUI : MonoBehaviour
{
    public TMP_Text scoreText;

    public ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    public void Update()
    {
        if (scoreManager != null && scoreManager.score > 0)
        {
            scoreText.text = $"{scoreManager.score}";
        }
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}
