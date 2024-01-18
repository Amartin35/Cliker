using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoClickUpgrade : MonoBehaviour
{
    public int autoClicksPerSecond;

    public int minimumClicksToUnlockUp;

    public SlimeInGame slime;

    public float health;

    private GameManager gameManager;

    public int ClickPower;

    public TextMeshProUGUI priceText, amountText;


    void Start()
    {
        gameManager = GameManager.instance;
        UpdateText();
    }

    // FONCTION ACHAT DE L AMELIORATION INFINI DE L AUTOCLICK
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
        if (slime == null)
        {
            slime = FindObjectOfType<SlimeInGame>();
        }
        health = slime.hp;
        ClickPower = gameManager.ClickPower;


        if (autoClicksPerSecond > 0)
        {
            gameManager.TotalClicks += autoClicksPerSecond * Time.deltaTime;

            gameManager.ClicksTotalText.text = gameManager.TotalClicks.ToString("0");
            health -= ClickPower * Time.deltaTime;
            slime.hp = health;

        }
    }

    // UPDATE LE TEXTE
    private void UpdateText()
    {
        priceText.text = "Need" + minimumClicksToUnlockUp.ToString() + "Golds";
        amountText.text = "+" + (autoClicksPerSecond + 1).ToString() + "/s";
    }
}
