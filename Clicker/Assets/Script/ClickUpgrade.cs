using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickUpgrade : MonoBehaviour
{
    
    public float minimumClicksToUnlockUp;
    
    private GameManager gameManager;

    public TextMeshProUGUI priceText, amountText;



    void Start()
    {

        gameManager = GameManager.instance;
        
        UpdateText();
    }

    public void BuyUpgrade()
    {
        if (gameManager.TotalClicks >= minimumClicksToUnlockUp)
        {
            gameManager.TotalClicks -= minimumClicksToUnlockUp;

            
            gameManager.ClickPower++;
            minimumClicksToUnlockUp *= 1.35f;

            UpdateText();
        }
    }

    private void UpdateText()
    {
        priceText.text = "Need" + Mathf.Round(minimumClicksToUnlockUp).ToString() + "Golds";
        amountText.text = "+" + (gameManager.ClickPower + 1).ToString() + "dmg";
    }
}
