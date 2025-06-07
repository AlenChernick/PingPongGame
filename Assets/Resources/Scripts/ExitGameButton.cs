using UnityEngine;

public class ExitGameButton : MonoBehaviour
{
    public void OnExitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}
