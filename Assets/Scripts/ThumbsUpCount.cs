using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class ThumbsUpCount : MonoBehaviour
{
    public int result=0;
    // Start is called before the first frame update
    public void onButtonClick()
    {
        result++;
        Debug.Log(result);
        

    }
    public void SaveData()
    {
        PlayerPrefs.SetInt("result",result);
        Debug.Log("Saved...");
    }

    

    
}
