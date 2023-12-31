using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
public GameObject slotPrefab;
public List<InventorySlot> InventorySlots = new List<InventorySlot>(4);

private void OnEnable()
{
Inventory.OnInventoryChange += DrawInventory;
}
private void OnDisable()
{
Inventory.OnInventoryChange -= DrawInventory;
}

void ResetInventory()
{
    foreach(Transform childTransform in transform)
    {
        Destroy(childTransform.gameObject);
    }
     InventorySlots = new List<InventorySlot>(4);
}
void DrawInventory(List<InventoryItem> Inventory)
{
    ResetInventory();

   for (int i = 0; i < InventorySlots.Capacity; i++)
   {
   CreateInventorySlot();
   }

   for (int i = 0; i < Inventory.Count; i++)
   {
    InventorySlots[i].DrawSlot(Inventory[i]);
   }

}

void CreateInventorySlot()
{
    GameObject newSlot = Instantiate(slotPrefab);
    newSlot.transform.SetParent(transform, false);
    InventorySlot newSlotComponent = newSlot.GetComponent<InventorySlot>();
    newSlotComponent.ClearSlot();
    InventorySlots.Add(newSlotComponent);
}
}
