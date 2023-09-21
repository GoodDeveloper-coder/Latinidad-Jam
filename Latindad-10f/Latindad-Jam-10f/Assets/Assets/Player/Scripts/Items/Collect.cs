using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
   public void OnTriggerEnter2D(Collider2D collision)
   {
    ICollectible collectible = collision.GetComponent<ICollectible>();
    if (collectible != null)
    {
        collectible.Collect();
    }
    }
}
