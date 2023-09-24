using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutFoodOnTableScript : MonoBehaviour
{
    public GameObject Food;
    public GameObject FoodPutPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Food")
        {
            Food.transform.parent = transform;
            Food.transform.position = FoodPutPosition.transform.position;
        }
    }

}
