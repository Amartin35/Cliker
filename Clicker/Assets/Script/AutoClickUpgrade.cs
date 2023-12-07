using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoClickUpgrade : MonoBehaviour
{
    public int autoClicksPerSecond;
    public int minimumClicksToUnlockUp;

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

            autoClicksPerSecond++;
            minimumClicksToUnlockUp *= 2;

            UpdateText();
        }
    }

    private void Update()
    {
        if (autoClicksPerSecond > 0)
        {
            gameManager.TotalClicks += autoClicksPerSecond * Time.deltaTime;

            gameManager.ClicksTotalText.text = gameManager.TotalClicks.ToString("0");
        }
    }

    private void UpdateText()
    {
        priceText.text = "Need" + minimumClicksToUnlockUp.ToString() + "Golds";
        amountText.text = "+" + (autoClicksPerSecond + 1).ToString() + "/s";
    }
}
