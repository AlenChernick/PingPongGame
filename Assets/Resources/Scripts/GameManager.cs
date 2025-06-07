using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public string winnerName;

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

    public void SetWinner(string name)
    {
        winnerName = name;
    }

    public string GetWinner()
    {
        return winnerName;
    }


}
