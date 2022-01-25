using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject ItemsContainer;

    private Item[] items;

    public void OnEnable()
    {
        items = ItemsContainer.GetComponentsInChildren<Item>();
        foreach (var item in items)
        {
            item.OnItemSelect += ActivateItem;
        }
    }

    public void ActivateItem()
    {
        SceneManager.LoadScene(1);
    }
}
