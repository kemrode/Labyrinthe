using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void QuitGame()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level01");

    }
}
