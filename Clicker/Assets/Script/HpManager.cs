using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{

    public Image healtBar;
    public float healtAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (healtAmount <= 0)
        {
            // CHANGER DE MONSTRE
        }

        if (/* MONSTRE TAKE DAMAGE)
        {
            TakeDamaged(20/* Amount Damage );
        }

        */
    }

    public void TakeDamaged(float damage)
    {
        healtAmount -= damage;
        healtBar.fillAmount = healtAmount / 100f;

    }


}
