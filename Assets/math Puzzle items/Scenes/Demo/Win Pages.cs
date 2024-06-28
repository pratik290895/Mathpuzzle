using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinPages : MonoBehaviour
{
    public GameObject Win, Home, Play;
    public Text text;

    public void OnClickContinue()
    {
        Win.SetActive(false);
        Play.SetActive(true);
    }

    public void OnClickMainMenu()
    {
        Win.SetActive(false);
        Home.SetActive(true);
    }

    private void OnEnable()
    {
        text.text = "PUZZLE " +  GameplayPages.Instance.Level + "COMPLETED";
    }
}

