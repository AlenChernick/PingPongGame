using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public string winnerName;
    public string playerName;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerName(string name)
    {
        playerName = name;
    }

    public string GetPlayerName()
    {
        return playerName;
    }

    public void SetWinner(string name)
    {
        winnerName = name;
    }

    public string GetWinner()
    {
        return winnerName;
    }


}
