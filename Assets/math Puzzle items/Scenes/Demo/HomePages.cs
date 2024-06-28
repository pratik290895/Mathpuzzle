using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePages : MonoBehaviour
{
    public GameObject Home, Play, Level;

    public void OnclickContinue()
    {
        Home.SetActive(false);
        Play.SetActive(true);
    }

    public void OnclickPuzzles()
    {
        Home.SetActive(false);
        Level.SetActive(true);
    }
}
