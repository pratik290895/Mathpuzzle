using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arpit_PlayManager : MonoBehaviour
{

    public int level;
    public Text Display, title;
    public string str;
    public Image CurrentBorad;
    public GameObject win;



    public string[] Answer = { "10", "25", "6", "14", "128", "7", "50", "1025", "100", "3", "212", "3011", "14", "16", "1", "2", "44", "45", "625", "1", "13", "47", "50", "34", "6", "41", "16", "126", "82", "14", "7", "132", "34", "48", "42", "288", "45", "4", "111", "47", "27", "87", "22", "253", "12", "48", "178", "1", "6", "10", "2", "20", "7", "5", "143547", "84", "11", "27", "3", "5", "39", "31", "10", "130", "22", "3", "14", "42", "164045", "11", "481", "86", "84", "13", "8" };
    public Sprite[] images;

    private void OnEnable()
    {
        Display.text = "";
        title.text = "Puzzle " + level.ToString();
        CurrentBorad.sprite = images[level - 1];
    }

    public void OnclickButtons(int number)
    {

        str += number.ToString();
        Display.text = str;
    }

    public void onclickBackBtn()
    {
        if (str.Length > 0)
        {
            str = str.Substring(0, str.Length - 1);
            Display.text = str;
        }

    }

    public void onclickSubmit()
    {
        if (Display.text == Answer[level - 1])
        {
            level++;
            this.transform.gameObject.SetActive(false);
            win.SetActive(true);
        }
        else
        {
            print("Plz try Again");
        }
    }
}
