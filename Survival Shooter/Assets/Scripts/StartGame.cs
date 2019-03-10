using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public int sceneToLoad;
    public void Play()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}