using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI ClicksTotalText;

    public SlimeInGame slime;

    public float health;

    public float TotalClicks;

    public int ClickPower;

    public static GameManager instance;

    public void Awake()
    {
        ClickPower += 1;
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {
        if(slime == null)
        {
            slime = FindObjectOfType<SlimeInGame>();
        }
        health = slime.hp;
    }

    // FONCTION QUI AJOUTE LES CLICKS
    public void AddClicks()
    {
        print("clique");
        TotalClicks += ClickPower;
        ClicksTotalText.text = TotalClicks.ToString("0");
        health -= ClickPower;
        slime.hp = health;
    }
}
