using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home : MonoBehaviour
{
    

    public GameObject Home, play, level, win;
    


    public string[] Answer = { "10", "25", "6", "14", "128", "7", "50", "1025", "100", "3", "212", "3011", "14", "16", "1", "2", "44", "45", "625", "1", "13", "47", "50", "34", "6", "41", "16", "126", "82", "14", "7", "132", "34", "48", "42", "288", "45", "4", "111", "47", "27", "87", "22", "253", "12", "48", "178", "1", "6", "10", "2", "20", "7", "5", "143547", "84", "11", "27", "3", "5", "39", "31", "10", "130", "22", "3", "14", "42", "164045", "11", "481", "86", "84", "13", "8" };
    public Sprite[] images;

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
    private void OnEnable()
    {
       
    }

}

