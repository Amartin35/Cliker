using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlimes : MonoBehaviour
{
    public List<SlimeInGame> slimeDataList;

    public SlimeInGame slime;

    public Transform pivot;

    private void Start()
    {
        Spawn_Slime();
    }
    
    // FAIS SPAWN UN SLIME DE MANIERE RANDOM PARMIS LA LISTE
    public void Spawn_Slime()
    {
        SlimeInGame slimeToSpawn = slimeDataList[Random.Range(0, slimeDataList.Count)];
        slime = Instantiate(slimeToSpawn, pivot.position, Quaternion.identity);
        slime.transform.localScale = new Vector3(2, 2, 2);
        slime.transform.localPosition = new Vector3(-0.5f, -0.5f, -1);
        slime.transform.eulerAngles = Vector3.up * -55;
    }

    // CHANGE DE SLIME SI SLIME MEURT
    private void Update()
    {
        if(slime.hp <= 0) 
        {
            Destroy(slime.gameObject);
            Spawn_Slime();
        }
    }
}