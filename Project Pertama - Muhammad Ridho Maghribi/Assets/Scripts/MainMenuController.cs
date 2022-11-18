using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By M.Ridho Maghribi");
    }

    public void Credit()
    {
        Debug.Log("Nama : Muhammad Ridho Maghribi");
        Debug.Log("GIT  : https://github.com/ridho665");
    }

}
