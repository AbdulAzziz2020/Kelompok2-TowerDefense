using UnityEngine;

public class SingletonMonoBehavior<T> : MonoBehaviour where T : Component
{
    public static T Instance;

    public void Awake()
    {
        if (Instance != this && Instance != null) Destroy(this.gameObject);
        else Instance = this as T;
    }
}