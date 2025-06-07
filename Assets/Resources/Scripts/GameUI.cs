using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text playerName;

    void Start()
    {
        string playerNameText = GameManager.instance != null ? GameManager.instance.GetPlayerName(): string.Empty;
        playerName.text = playerNameText;
    }
}
