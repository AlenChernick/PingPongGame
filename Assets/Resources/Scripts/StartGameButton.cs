using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public void StartGame(int seceneId)
    {
        SceneManager.LoadScene(seceneId);
    }
}
