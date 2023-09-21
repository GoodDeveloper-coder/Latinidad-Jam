using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
public Image Icon;
public TextMeshProUGUI labelText;

public void ClearSlot()
{
    Icon.enabled = false;
    labelText.enabled = false;
}
public void DrawSlot(InventoryItem item)
{
    if (item == null)
    {
        ClearSlot();
        return;
    }
    else
    {
    Icon.enabled = true;
    labelText.enabled = true;

    Icon.sprite = item.itemData.icon;
     labelText.text = item.itemData.displayName;
    }
}
}
