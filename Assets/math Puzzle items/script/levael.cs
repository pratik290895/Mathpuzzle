using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levael : MonoBehaviour
{
    public static levael inst;
    public bool is_paased;
    
    private void Awake()
    {
        inst = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void unable_lavel()
    {
        
        Debug.Log("unable_lavel"+ ui_manger.Inst.lev_no);
        for (int i = 0; i < ui_manger.Inst.lev_no - 1; i++)
        {

            //tick true and level passs
            ui_manger.Inst.leval_btn[i].transform.GetChild(0).gameObject.SetActive(true);

            ui_manger.Inst.leval_btn[i].transform.GetChild(1).GetComponent<Text>().enabled = true ;
            ui_manger.Inst.leval_btn[i].GetComponent<Button>().interactable = true;
            ui_manger.Inst.leval_btn[i].GetComponent<Image>().sprite = ui_manger.Inst.lev_btn_img;

            // tick false but level unlocked 
            ui_manger.Inst.leval_btn[ui_manger.Inst.lev_no - 1].GetComponent<Image>().sprite = ui_manger.Inst.lev_btn_img;
            ui_manger.Inst.leval_btn[ui_manger.Inst.lev_no - 1].GetComponent<Button>().interactable = true;
            ui_manger.Inst.leval_btn[ui_manger.Inst.lev_no - 1].transform.GetChild(1).GetComponent<Text>().enabled =true ;  

        }
    }

    public void onclicklavel(int n)
    {
        print(n);
        if (n == ui_manger.Inst.lev_no)
        {
            ui_manger.Inst.isReplay = false;
            ui_manger.Inst.onclick_continue();
        }
        else
        {
            ui_manger.Inst.isReplay = true;
            ui_manger.Inst.replayNumber = n;
            ui_manger.Inst.onclick_alll_continue(n);
        }

    }
}
