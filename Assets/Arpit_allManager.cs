using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arpit_allManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject home, play, level, win;
   

    public void onclikcContinue()
    {
        home.SetActive(false);
        play.SetActive(true);
    }

    public void onclikcPuzzle()
    {
        home.SetActive(false);
        level.SetActive(true);
    }

    public void onclickWinContinue()
    {
       play.SetActive(true);
        win.SetActive(false);
    }
}
