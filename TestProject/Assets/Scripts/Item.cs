using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   [SerializeField] private GameObject ItemPrefab;
   [SerializeField] private ItemsHolder itemsHolder;

   public event Action OnItemSelect;

   public void PressButtom()
   {
      itemsHolder.SetPrefab(ItemPrefab);
      OnItemSelect?.Invoke();
   }
}
