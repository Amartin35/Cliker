using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI ClicksTotalText;

    float TotalClicks;


    bool hasUpgrade;

    public int autoClicksPerSecond;
    public int minimumClicksToUnlockUp;



    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString("0");
    }

    public void AutoClickUpgrade()
    {
        if(!hasUpgrade && TotalClicks >= minimumClicksToUnlockUp)
        {
            TotalClicks -= minimumClicksToUnlockUp;
            hasUpgrade = true;
        }
    }

    private void Update()
    {
        if (hasUpgrade)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime;
            ClicksTotalText.text = TotalClicks.ToString("0");
        }
    }
}
