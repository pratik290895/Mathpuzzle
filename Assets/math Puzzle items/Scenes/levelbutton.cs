using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelbutton : MonoBehaviour
{
    public GameObject Tick;
    public void UnlockLevel()
    {
        Tick.SetActive(true);
    }


}
