using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResultSet : MonoBehaviour
{

    public int loadedPlayerPref;
    public GameObject screenUI;
    // Start is called before the first frame update
    
     void Start()
    {
      loadedPlayerPref= PlayerPrefs.GetInt("result");
      
      
          screenUI.GetComponent<Text>().text= "Healthy choices :"+loadedPlayerPref;
      
      
        //screenUI.GetComponent<Text>().text= "";
      
      
      
       Debug.Log("loaded");
      
    }
}
