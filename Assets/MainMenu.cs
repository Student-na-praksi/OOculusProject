using System;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject FirstPersonController;
    public GameObject Canvas;
    private bool isPaused = true;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("isThisFirstLoad"));
        if (PlayerPrefs.GetString("isThisFirstLoad") != "False")
        {
            PlayerPrefs.SetString("isThisFirstLoad", "False");
            FirstPersonController.SetActive(false);
            Canvas.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            isPaused = true;
        }
        else
        {
            FirstPersonController.SetActive(true);
            Canvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            isPaused = false;
        }
        
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
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        Application.Quit();
    }
}
