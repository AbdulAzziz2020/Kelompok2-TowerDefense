using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Attack/Melee", fileName = "Melee Attack")]
public class MeleeAttack : ScriptableObject
{
    [Header("Weapon Description")]
    public string weaponName;
    public string description;

    [Header("Weapon Status")]
    public int projectileDamage;
}