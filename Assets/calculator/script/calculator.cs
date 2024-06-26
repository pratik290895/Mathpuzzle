using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class calculator : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject no;
    public Text result;
    internal string str, str1, op;
    double num1, num2, sum = 0, num3;
    public Button btn;
    void Start()
    {
        result.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onclick_num(int number)
    {
        result.text = double.Parse(result.text + number).ToString();
    }
    public void onclick_add()
    {
        num1 = double.Parse(result.text);
        op = "add";
        Debug.Log(num1);
        result.text = "";
    }
    public void onclick_sub()
    {
        num1 = double.Parse(result.text);
        result.text = "";
        op = "sub";
    }
    public void onclick_mul()
    {
        num1 = double.Parse(result.text);
        result.text = "";
        op = "mul";
    }
    public void onclick_div()
    {
        num1 = double.Parse(result.text);
        result.text = "";
        op = "div";
    }
    public void onclick_mod()
    {
        num1 = double.Parse(result.text);
        result.text = "";
        op = "mod";
    }
    public void onclick_clr()
    {
        btn.interactable = true;
        result.text = "0";
    }
    public void onclick_dot()
    {
        if (!result.text.Contains("."))
        {
            result.text += ".";
        }
    }
    public void onclick_eq()
    {
        num2 = double.Parse(result.text);
        Debug.Log(num2);
        if (op.Equals("add"))
        {
            sum = num1 + num2;
        }
        if (op.Equals("sub"))
        {
            sum = num1 - num2;
        }
        if (op.Equals("mul"))
        {
            sum = num1 * num2;
        }
        if (op.Equals("div"))
        {
            sum = num1 / num2;
        }
        if (op.Equals("mod"))
        {
            sum = (num1 * 100) / num2;
        }
        Debug.Log(sum.ToString());
        result.text = sum.ToString();
        btn.interactable = false;
    }
    public void onclick_pm()
    {
        num3 = double.Parse(result.text);
        sum = 0 - (num3);
        result.text = sum.ToString();
    }
    public void onclick_clr_one()
    {
        if (result.text.Length > 0)
        {
            result.text = result.text.Substring(0, result.text.Length - 1);
        }
        if (result.text.Length == 0)
        {
            result.text = "0";
            btn.interactable = true;
        }
    }
}
