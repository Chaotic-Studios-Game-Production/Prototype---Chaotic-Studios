using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("Level 2");
    }
}
