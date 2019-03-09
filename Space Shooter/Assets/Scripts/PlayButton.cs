using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public int sceneToLoad;
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
    }
}