using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPickable : MonoBehaviour
public interface IPickable
{
    string ItemName { get; }
    void OnPickup();
}
