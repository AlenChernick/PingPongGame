using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Text winnerText;

    void Start()
    {
        string winnerName = GameManager.instance != null ? GameManager.instance.GetWinner(): string.Empty;
        winnerText.text = $"{winnerName} Won!";
    }
}
