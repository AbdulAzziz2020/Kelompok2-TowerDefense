using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public void InitPool<T>(Transform origin, int size, T prefab, List<T> list) where T : Component
    {
        for (int i = 0; i < size; i++)
        {
            T obj = Instantiate(prefab, origin);
            obj.gameObject.SetActive(false);
            list.Add(obj);
        }
    }

    public T GetObjectInPool<T>(List<T> list) where T : Component
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (!list[i].gameObject.activeInHierarchy) return list[i];
        }

        return null;
    }

    public void SetActiveObjectInPool<T>(Transform origin, List<T> list) where T : Component
    {
        T obj = GetObjectInPool<T>(list);

        if (obj != null)
        {
            obj.transform.position = origin.transform.position;
            obj.gameObject.SetActive(true);
        }
    }
}