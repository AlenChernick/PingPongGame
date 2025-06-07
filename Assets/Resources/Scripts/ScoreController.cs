using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int playerScore = 0;
    private int enemyScore = 0;

    public GameObject playerScoreText;
    public GameObject enemyScoreText;

    public int scoreToWin;

    void Update()
    {
        if (playerScore >= scoreToWin || enemyScore >= scoreToWin)
            SceneManager.LoadScene("GameOver");
    }

    private void FixedUpdate()
    {
        Text uiPlayerScore = playerScoreText.GetComponent<Text>();
        uiPlayerScore.text = playerScore.ToString();

        Text uiEnemyScore = enemyScoreText.GetComponent<Text>();
        uiEnemyScore.text = enemyScore.ToString();
    }

    public void GoalPlayer()
    {
        playerScore++;
    }

    public void GoalEnemy()
    {
        enemyScore++;
    }


}
