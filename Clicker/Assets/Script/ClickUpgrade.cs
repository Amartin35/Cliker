using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickUpgrade : MonoBehaviour
{
    public int powerClick;
    public float minimumClicksToUnlockUp;
    S
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

            powerClick++;
            minimumClicksToUnlockUp *= 1.35f;

            UpdateText();
        }
    }

    private void UpdateText()
    {
        priceText.text = "Need" + Mathf.Round(minimumClicksToUnlockUp).ToString() + "Golds";
        amountText.text = "+" + (powerClick + 1).ToString() + "dmg";
    }
}
