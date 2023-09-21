using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<IPickable> items = new List<IPickable>();
    public KeyCode pickupKey = KeyCode.E; // Key to pick up items

    private void Update()
    {
        if (Input.GetKeyDown(pickupKey))
        {
            TryPickupItem();
        }
    }

    private void TryPickupItem()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            IPickable pickable = hit.collider.GetComponent<IPickable>();
            if (pickable != null)
            {
                items.Add(pickable);
                pickable.OnPickup();
                Debug.Log("Added to inventory: " + pickable.ItemName);
            }
        }
    }
}