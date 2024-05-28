using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public static SceneManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ShowLoading()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Loading");
    }

    public void ShowLobby()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lobby");
    }
}