using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PutFoodOnTableScript : MonoBehaviour
{
    //public GameObject Food;
    public GameObject FoodPutPosition;

    [SerializeField] private TextMeshProUGUI MoneyText;
    public GlobalValues GB;

    private bool CanPutFood = true;

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
        if (other.gameObject.tag == "Food")
        {
            if (CanPutFood)
            {
                other.GetComponent<Collider2D>().enabled = false;
                other.transform.parent = transform;
                other.transform.position = FoodPutPosition.transform.position;
                GB.Money += 200;
                MoneyText.text = string.Format("Money: {0}", GB.Money);
                CanPutFood = true;
            }
        }
    }
}
