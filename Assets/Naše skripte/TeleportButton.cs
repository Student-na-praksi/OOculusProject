using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportButton : MonoBehaviour
{
    public string sceneName; // Name of the scene to teleport to.

    public void Teleport()
    {
        Debug.Log("Teleport function called. Loading scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}