using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;


public class GameplayPages : MonoBehaviour
{
    public static GameplayPages Instance;
    public GameObject GamePlayPage, WinPage;
    public Text DisPlaytext,Titletext;
    public Image Questionimage;
    public string str;
    public int Level;
    public Sprite[] Image;
    public Text Text;

    public string[] Answer = { "10", "25", "6", "14", "128", "7", "50", "1025", "100", "3", "212", "3011", "14", "16", "1", "2", "44", "45", "625", "1", "13", "47", "50", "34", "6", "41", "16", "126", "82", "14", "7", "132", "34", "48", "42", "288", "45", "4", "111", "47", "27", "87", "22", "253", "12", "48", "178", "1", "6", "10", "2", "20", "7", "5", "143547", "84", "11", "27", "3", "5", "39", "31", "10", "130", "22", "3", "14", "42", "164045", "11", "481", "86", "84", "13", "8" };
    public void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void OnclickButton(int number)
    {
        str += number.ToString();
        DisPlaytext.text = str;
    }
    public void ClickButton()
    {
        if (str.Length > 0) 
        {
            str=str.Substring(0, str.Length - 1);
            DisPlaytext.text = str;
        }

    }
    public void OnEnable()
    {
        if (!PlayerPrefs.HasKey("Level"))
        {
            Level = 1;
            PlayerPrefs.SetInt("Level",Level);

        }
        else 
        {
           Level= PlayerPrefs.GetInt("Level");
        }
        DisPlaytext.text = "";
        str = "";
        Titletext.text = "Puzzle" + Level.ToString();
        Questionimage.sprite = Image[Level - 1];
        Text.text = "";


    }
    public void Submit()
    {
        if (DisPlaytext.text == Answer[Level - 1])
        {
            WinPage.SetActive(true);
            GamePlayPage.SetActive(false);
            DisPlaytext.text = "";
            str = "";
            Level++;
            PlayerPrefs.SetInt("Level",Level);


        }
    }
    public void OnClickSkip() 
    {
        Level++;
        PlayerPrefs.SetInt("Level", Level);
        GamePlayPage.SetActive(false);
        GamePlayPage.SetActive(true);

    }
    public void OnClickHint() 
    {
        Debug.Log("hint  " +Answer[Level - 1]);
        Text.text =Answer[Level - 1];
    }



}
