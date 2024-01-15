using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI ClicksTotalText;

    public float TotalClicks;

    public int ClickPower;

    public static GameManager instance;


    public void Awake()
    {
        ClickPower += 1;
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void AddClicks()
    {
        print("clique");
        TotalClicks += ClickPower;
        ClicksTotalText.text = TotalClicks.ToString("0");
    }


}
