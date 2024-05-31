using System;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject FirstPersonController;
    public GameObject Canvas;
    private bool isPaused = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if (Input.GetButtonDown("Cancel") && !isPaused)
        {
            Pause();
        }
    }

    void Pause()
    {
        isPaused = true;
        FirstPersonController.SetActive(false);
        Canvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayButton()
    {
        Canvas.SetActive(false);
        FirstPersonController.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        isPaused = false;
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
