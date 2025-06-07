using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    public InputField playerNameInput;

    public void StartGame(int seceneId)
    {
        string playerName = string.Empty;

        if (GameManager.instance == null)
            return;

        if (playerNameInput != null)
            playerName = playerNameInput.text;
        else
            playerName = GameManager.instance.GetPlayerName();

        if (string.IsNullOrEmpty(playerName))
            return;

        GameManager.instance.SetPlayerName(playerName);
        SceneManager.LoadScene(seceneId);
    }
}
