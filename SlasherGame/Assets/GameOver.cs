using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame() {
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Quit");
        Application.Quit();
    }
}
