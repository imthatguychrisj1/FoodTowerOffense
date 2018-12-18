using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelect : MonoBehaviour
{
    public string BuildScene;

    void OnMouseDown()
    {
      SceneManager.LoadScene(BuildScene);
      Debug.Log("Button Clicked");
 
    }
}

