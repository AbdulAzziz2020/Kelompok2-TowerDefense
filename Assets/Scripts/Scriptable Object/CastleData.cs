using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/Player/Castle Data", fileName = "Castle Data")]
public class CastleData : ScriptableObject
{
    [Header("Castle Description")] 
    public string castleName;
    [TextArea(5, 10)] public string description;

    [Header("Castle Status")]
    public int baseHealth;
    public int baseDefense;
    
    [Header("GameObject")] 
    public GameObject castlePrefab;
}