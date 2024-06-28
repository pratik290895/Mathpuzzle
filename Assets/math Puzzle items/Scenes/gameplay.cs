using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameplay : MonoBehaviour
{
    public static gameplay instance;
    public String str;
    public Text Title;
    public int level;
    public Image currentBoard;
    public Sprite[] images;
    public GameObject Wincanvas, GamePlayCanvas;
    public Text displayText;




    public string[] Answer = { "10", "25", "6", "14", "128", "7", "50", "1025", "100", "3", "212", "3011", "14", "16", "1", "2", "44", "45", "625", "1", "13", "47", "50", "34", "6", "41", "16", "126", "82", "14", "7", "132", "34", "48", "42", "288", "45", "4", "111", "47", "27", "87", "22", "253", "12", "48", "178", "1", "6", "10", "2", "20", "7", "5", "143547", "84", "11", "27", "3", "5", "39", "31", "10", "130", "22", "3", "14", "42", "164045", "11", "481", "86", "84", "13", "8" };



    private void Awake()
    {
        
        if(instance==null)
            instance = this;
       
    }
    public void OnClickBtn(int number)
    {
        str += number.ToString();
        displayText.text = str;
    }
    public void OnClickBtn()
    {
        if (str.Length > 0)
            str = str.Substring(0, str.Length - 1);
        displayText.text = str;
    }
    private void OnEnable()
    {
        if (!PlayerPrefs.HasKey("level"))
        {
            level = 1;
            PlayerPrefs.SetInt("level", level);
        }
        else
        {
            level = PlayerPrefs.GetInt("level");
        }


        displayText.text = "";
        str = "";
        Title.text = "Puzzle " + level.ToString();
        currentBoard.sprite = images[level - 1];
    }
    public void Submit()
    {
        if (displayText.text == Answer[level - 1])
        {
            Wincanvas.SetActive(true);
            GamePlayCanvas.SetActive(false);
            str = "";
            displayText.text = "";
            level++;
            PlayerPrefs.SetInt("level",level);
        }
        else
        {
            str = "";
            displayText.text = "";
        }


    }
    



}
