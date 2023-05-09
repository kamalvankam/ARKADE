using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultSetForBad : MonoBehaviour
{
    public int loadedPlayerPref;
    public GameObject screenUI;
    // Start is called before the first frame update
    
     void Start()
    {
      loadedPlayerPref= PlayerPrefs.GetInt("downCount");
      
      
          screenUI.GetComponent<Text>().text= "UnHealthy choices :"+loadedPlayerPref;
      
      
        //screenUI.GetComponent<Text>().text= "";
    
      
      
       Debug.Log("Bad loaded");
      
    }
}
