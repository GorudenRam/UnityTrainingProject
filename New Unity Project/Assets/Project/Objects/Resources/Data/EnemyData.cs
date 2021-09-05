using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Data/Enemy", order = 51)]
[System.Serializable]
public class EnemyData : ScriptableObject
{
    public Sprite sprite;
    public float HeatPoints;
    public float speed;
}
