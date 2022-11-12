using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Enemy/Enemy Data", fileName = "Enemy Data")]
public class EnemyData : ScriptableObject
{
    [Header("Enemy Description")]
    public string enemyName;
    [TextArea(5, 10)] public string description;

    [Header("Enemy Status")]
    public int baseHealth;
    public float baseSpeed;
    public float attackRange;
    public float timeBetweenAttack;

    [Header("GameObject")]
    public GameObject enemyPrefab;
}