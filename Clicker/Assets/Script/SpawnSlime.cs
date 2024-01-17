using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlimes : MonoBehaviour
{
    public List<Slime> slimeDataList;

    private void Start()
    {
        foreach (Slime slimeData in slimeDataList)
        {
            GameObject slime = Instantiate(slimeData.slimePrefab, slimeData.spawnPosition, Quaternion.identity);
            slime.transform.localScale = new Vector3(2, 2, 2);
            slime.transform.eulerAngles = Vector3.up * -55;
        }
    }
}


