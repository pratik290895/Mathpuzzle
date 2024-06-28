using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WINPAGE : MonoBehaviour
{
    public GameObject Play, Win, Home;
    public  Text Text;
   
    
    
    public void ClickContinue()
    {
        Play.SetActive(true);
        Win.SetActive(false);
        
    }
    public void ClickMainManu()
    {
       
        Home.SetActive(true);
        Win.SetActive(false);
    }
    private void OnEnable()
    {
        Text.text = "PUZZLE " + gameplay.instance.level + " COMPLETED";

    }
}
