using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainScene : MonoBehaviour
{
    //launch menu from back to menu button in the scene
    public void LaunchMenu()
    {
        SceneManager.LoadScene(0);
    }
}
