using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Static variable that holds the instance of the GameObject
    public static DontDestroy instance;

    void Awake()
    {
        // If no instance exists
        if (instance == null)
        {
            // Set this GameObject as the instance
            instance = this;

            // Make this GameObject persist across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists and it's not this GameObject, destroy this GameObject
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}