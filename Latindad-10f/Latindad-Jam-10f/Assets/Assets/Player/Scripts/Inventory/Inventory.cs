using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    public static event Action<List<InventoryItem>> OnInventoryChange;
 public List<InventoryItem> inventory = new List<InventoryItem>();
 private Dictionary<ItemData, InventoryItem> ItemDictionary = new Dictionary<ItemData, InventoryItem>();

private void OnEnable()
{
    Meat.OnMeatCollected += Add;
}
private void OnDisable()
{
    Meat.OnMeatCollected -= Add;
}
public void Add(ItemData itemData)
{
    if (ItemDictionary.TryGetValue(itemData, out InventoryItem item))
    {
        item.addToStack();
        OnInventoryChange?.Invoke(inventory);
    }
    else 
    {
        InventoryItem newItem = new InventoryItem(itemData);
        inventory.Add(newItem);
        ItemDictionary.Add(itemData, newItem);
        OnInventoryChange?.Invoke(inventory);
    }
   
}
 public void Remove(ItemData itemData)
 {
  if (ItemDictionary.TryGetValue(itemData, out InventoryItem item))
    {
        item.RemoveFromStack();
        if(item.stackSize == 0)
        {
            inventory.Remove(item);
            ItemDictionary.Remove(itemData);

        }
        OnInventoryChange?.Invoke(inventory);
    }
 }
}

