using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPages : MonoBehaviour
{
    public Button[] Button;
    public Sprite LockSprite,DefultSprite;
    public int Level;
    public GameObject LevelPage, GamePlayPage;

    private void OnEnable()
    {
        if (!PlayerPrefs.HasKey("Level"))
        {
            Level = 1;
            PlayerPrefs.SetInt("Level", Level);

        }
        else
        {
           Level= PlayerPrefs.GetInt("Level");
        }
        for (int i = 0; i < Button.Length; i++) 
        {
            int no = i;
            Button[i].onClick.AddListener(()=>Btn(no)); 
            Button[i].GetComponent<Image>().sprite = LockSprite;
            Button[i].transform.GetChild(0).gameObject.SetActive(false);
            Button[i].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);

        }
        for (int i = 0; i < Level; i++) 
        {
            Button[i].interactable = true;
            Button[i].GetComponent<Image>().sprite = DefultSprite;
            Button[i].transform.GetChild(0).gameObject.SetActive(true);
            //Button[i].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(true);
            Button[i].transform.GetChild(0).GetComponent<Text>().text = (i+1).ToString();
        }
        for (int i = 0; i < Level-1; i++)
        {
            Button[i].GetComponent<Image>().sprite = DefultSprite;
            Button[i].transform.GetChild(0).gameObject.SetActive(true);
            Button[i].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(true);

        }


    }
    public void Btn(int no) 
    {
        LevelPage.SetActive(false);
        GamePlayPage.SetActive(true);
    }
    




}
