using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemsHolder", menuName = "ItemsHolderSO", order = 51)]
public class ItemsHolder : ScriptableObject
{
    private GameObject prefab;

    public GameObject GetPrefab()
    {
        return prefab;
    }

    public void SetPrefab(GameObject ItemPrefab)
    {
        prefab = ItemPrefab;
    }
}
