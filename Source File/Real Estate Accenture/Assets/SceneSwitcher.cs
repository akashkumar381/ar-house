﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    
    public void GotoMainScene()
    {
        SceneManager.LoadScene("RealEstate");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    
   
}
