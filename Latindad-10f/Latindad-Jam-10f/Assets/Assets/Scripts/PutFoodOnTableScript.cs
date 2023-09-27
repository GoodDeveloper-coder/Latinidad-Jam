using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PutFoodOnTableScript : MonoBehaviour
{
    //public GameObject Food;
    public GameObject FoodPutPosition;

    [SerializeField] private TextMeshProUGUI MoneyText;
    public GlobalValues GlobalValues;

    private bool CanPutFood = true;

    public PickUpFoodScript PFS;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = string.Format("Money: {0}", GlobalValues.Money);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            if (CanPutFood && GlobalValues.EnterInPeopleZone)
            {
                other.GetComponent<Collider2D>().enabled = false;
                other.transform.parent = transform;
                other.transform.position = FoodPutPosition.transform.position;
                GlobalValues.Money += GlobalValues.FoodPrice;
                MoneyText.text = string.Format("Money: {0}", GlobalValues.Money);
                StartCoroutine(CanPutFoodWaitTime());
                PFS.CanPickUp = true;
                CanPutFood = false;
            }
        }
    }

    IEnumerator CanPutFoodWaitTime()
    {
        yield return new WaitForSeconds(20.0f);
        CanPutFood = true;
    }
}
