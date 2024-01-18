using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
    public SlimeInGame slime;

    public Image healtBar;

    public float healtAmount = 100f;

    // MANAGE LA BARRE DE VIE
    void Update()
    {
        if (slime == null)
        {
            slime = FindObjectOfType<SlimeInGame>();
        }
        healtAmount = slime.hp;
        healtBar.fillAmount = healtAmount / 100f;
    }
}
