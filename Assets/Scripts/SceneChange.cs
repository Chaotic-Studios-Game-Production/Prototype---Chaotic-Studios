using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ChangeSecondScene()
    {
        Debug.Log("button click");
        SceneManager.LoadScene("Level2");
    }
}
