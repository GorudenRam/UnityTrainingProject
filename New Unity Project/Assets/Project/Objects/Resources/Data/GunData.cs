using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Data/Gun", order = 51)]
[System.Serializable]
public class GunData : ScriptableObject
{
    public GameObject bullet;
    public float fire_delay;
    public float damage;
}
