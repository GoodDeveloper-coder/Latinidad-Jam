using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
, IPickable
{
    public string itemName = "Item";

    public string ItemName
    {
        get { return itemName; }
    }

    public void OnPickup()
    {
        Debug.Log("Picked up: " + itemName);
        gameObject.SetActive(false);
    }
}