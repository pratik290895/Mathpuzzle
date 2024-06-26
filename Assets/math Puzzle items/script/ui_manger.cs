using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ui_manger : MonoBehaviour
{
    public static ui_manger Inst;
    public GameObject home, play, lavels, win_screen;
    public Image que_image;
    internal string str = "";
    public Text puz_no;
    public Text r_ans, f_ans;
    public string[] Answer = { "10", "25", "6", "14", "128", "7", "50", "1025", "100", "3", "212", "3011", "14", "16", "1", "2", "44", "45", "625", "1", "13", "47", "50", "34", "6", "41", "16", "126", "82", "14", "7", "132", "34", "48", "42", "288", "45", "4", "111", "47", "27", "87", "22", "253", "12", "48", "178", "1", "6", "10", "2", "20", "7", "5", "143547", "84", "11", "27", "3", "5", "39", "31", "10", "130", "22", "3", "14", "42", "164045", "11", "481", "86", "84", "13", "8" };
    public Sprite[] images;
    public GameObject[] leval_btn;
    public int lev_no = 1, replayNumber;
    public Sprite lev_btn_img;
    internal bool isReplay;
    public GameObject wrong_ans;

    void Start()
    {
        Inst = this;
        if (!PlayerPrefs.HasKey("current_leval_no"))
        {
            PlayerPrefs.SetInt("current_leval_no", 1);
        }
        else
        {
            lev_no = PlayerPrefs.GetInt("current_leval_no");
        }
        for (int i = 0; i < leval_btn.Length; i++)
        {
            leval_btn[i].transform.GetChild(1).GetComponent<Text>().text = (i+1).ToString();
        }
        Debug.Log(leval_btn.Length);
    }
    public void ruf_ans(int n)
    {
        str = string.Concat(str, n);
        Debug.Log(str);
        r_ans.text = str;
    }
    public void onclick_continue()
    {
        home.SetActive(false);
        play.SetActive(true);
        que_image.sprite = images[lev_no - 1];
        win_screen.SetActive(false);
        puz_no.text = "Puzzle " + lev_no;
    }
    public void onclick_alll_continue(int n)
    {
        home.SetActive(false);
        play.SetActive(true);
        que_image.sprite = images[n - 1];
        win_screen.SetActive(false);
        puz_no.text = "Puzzle " + n;

    }
    public void onclick_puzzle()
    {
        home.SetActive(false);
        lavels.SetActive(true);
        Debug.Log("HOLD");
        levael.inst.unable_lavel();

    }
    public void onclick_back()
    {
        str = str.Substring(0, str.Length - 1);
        r_ans.text = str;

    }
    public void onclick_submit()
    {
        wrong_ans.SetActive(false);
        if (str == Answer[lev_no - 1] && !isReplay)
        {
            win_screen.SetActive(true);
            str = "";
            lev_no++;
            PlayerPrefs.SetInt("current_leval_no", lev_no);
            f_ans.text = "PUZZLE " + lev_no + " COMPLETED";

        }
        else if (isReplay)
        {
            if (str == Answer[replayNumber - 1])
            {
                win_screen.SetActive(true);
                str = "";
                f_ans.text = "PUZZLE " + replayNumber + " COMPLETED";
            }
            else
            {
                wrong_ans.SetActive(true);
            }
        }
        else
        {
            wrong_ans.SetActive(true);
        }
        str = "";
        r_ans.text = "";
    }
    public void onclick_main_menu()
    {
        lavels.SetActive(true);
        levael.inst.unable_lavel();
        win_screen.SetActive(false);
        play.SetActive(false);
        lavels.SetActive(false);
        home.SetActive(true);
    }
}
