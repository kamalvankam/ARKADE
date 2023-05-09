using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeScene : MonoBehaviour
{
    
    

    public void LoadARScene()
    {
        SceneManager.LoadScene("EndScene");
        Debug.Log("Working...");
        
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    
    
    
    
}
