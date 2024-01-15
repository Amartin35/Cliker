using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Slime", menuName = "Slime", order =0)]
public class Slime : ScriptableObject
{
    public string slimeNumber;

    public float hp;

    public float level;

    public Mesh slimeSprite;


}
