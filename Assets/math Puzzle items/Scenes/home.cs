using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home : MonoBehaviour
{
    

    public GameObject Home, play, level;
    


    

    public void OnclickContinue()
    {
        Home.SetActive(false);
        play.SetActive(true);
    } 
    public void OnclickPuzzle() 
    {
        Home.SetActive(false);
        level.SetActive(true);
    }
}

