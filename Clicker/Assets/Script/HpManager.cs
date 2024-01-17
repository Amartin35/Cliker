using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
    public SlimeInGame slime;
    public Image healtBar;
    public float healtAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slime == null)
        {
            slime = FindObjectOfType<SlimeInGame>();
        }
        healtAmount = slime.hp;
        healtBar.fillAmount = healtAmount / 100f;
    }

    public void TakeDamaged(float damage)
    {
        healtAmount -= damage;
        healtBar.fillAmount = (float)healtAmount / 100f;
    }


}
