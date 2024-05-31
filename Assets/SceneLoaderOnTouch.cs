using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderOnTouch : MonoBehaviour
{
    [SerializeField]
    private GameObject target; // Replace with the tag of the target object
    [SerializeField]
    public string sceneName; // Replace with the name of the scene you want to load

    // For triggers (requires "Is Trigger" to be enabled in the collider)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // For collisions (when colliders are not marked as triggers)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        if (collision.collider == target)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
