using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class UI_InventoryPage : MonoBehaviour
{
    [SerializeField]
    private UI_InventoryItem itemPrefab;
    [SerializeField]
    private RectTransform contentPanel;

    List<UI_InventoryItem> UI_ItemList = new List<UI_InventoryItem>();

    public void UI_InitializeInventory(int inventorySize)
    {
        for (int i = 0; i < inventorySize; i++)
        {
            UI_InventoryItem ui_item = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            ui_item.transform.SetParent(contentPanel);
            UI_ItemList.Add(ui_item);
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
