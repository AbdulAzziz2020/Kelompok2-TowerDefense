using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Attack/Ranged", fileName = "Ranged Attack")]
public class RangedAttack : ScriptableObject
{
    [Header("Weapon Description")]
    public string weaponName;
    public string description;

    [Header("Weapon Status")]
    public int projectileDamage;
    public float projectileSpeed;

    [Header("Projectile")]
    public GameObject projectilePrefab;
}