using UnityEngine;
using UnityEngine.UI;

public class levelpage : MonoBehaviour
{
    public static levelpage instance;
    public GameObject[] Button;
    public GameObject Level, GamePlay;
    public int level;
    public Sprite Defult;

    private void OnEnable()
    {
        for (int i = 0; i < Button.Length; i++)
        {
            int number = i;
            Button[i].GetComponent<Button>().onClick.AddListener(() =>
            {
                clickButton(number + 1);
            });
        }
        if (!PlayerPrefs.HasKey("level"))
        {
            //print("if call");
            level = 1;
            PlayerPrefs.SetInt("level", level);
        }
        else
        {
            print("else call");
            level = PlayerPrefs.GetInt("level");
        }
        for (int i = 0; i < level; i++)
        {
            Button[i].GetComponent<Button>().interactable = true;
            Button[i].transform.GetChild(0).gameObject.SetActive(true);
            Button[i].transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
            Button[i].transform.GetChild(0).GetComponent<Text>().text = (i+1).ToString();
            Button[i].GetComponent<Image>().sprite = Defult;
        }
        for (int i = 0; i < level - 1; i++)
        {
            Button[i].GetComponent<levelbutton>().UnlockLevel();  
        }
    }


    public void clickButton(int level)
    {
        Debug.Log("level no= " + level);
        //gameplay.instance.level = level;
        PlayerPrefs.SetInt("level", level);
        GamePlay.SetActive(true);
        Level.SetActive(false);
    }


}
