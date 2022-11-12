using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Player/Tower Data", fileName = "Tower Data")]
public class TowerData : ScriptableObject
{
    [Header("Tower Description")]
    public string towerName;
    [TextArea(5, 10)] public string description;

    [Header("Tower Status")] 
    public int baseHealth;
    public float attackSpeed;
    public float attackRange;
    public float timeBetweenAttack;

    [Header("GameObject")] 
    public GameObject towerPrefab;
}
