using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour
{
    public void StartGameButtonClicked()
    {
        // Load the next scene.
        SceneManager.LoadScene("Start_Screen");
    }
}