using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThumbsDownCount : MonoBehaviour
{
    // Start is called before the first frame update
   public int downCount=0;
    // Start is called before the first frame update
    public void onButtonClick()
    {
        downCount++;
        Debug.Log("down count"+downCount);
        

    }
    public void SaveData()
    {
        PlayerPrefs.SetInt("downCount",downCount);
        Debug.Log("Saved...");
    }
}
