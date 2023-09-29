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

    public AudioSource PutFoodOnTableSound;

    public AudioSource GotMoneySound;

    private GameObject FoodTransformLocation;

    private Transform FoodTransformLocationn;

    public int ChildFoodNumberInList = 5;

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
                FoodTransformLocationn = this.gameObject.transform.GetChild(4).GetChild(0);
               // (ChildFoodNumberInList);
                //FoodTransformLocation = GameObject.FindGameObjectWithTag("People");
                PutFoodOnTableSound.Play();
                other.GetComponent<Collider2D>().enabled = false;
                other.transform.parent = FoodTransformLocationn.transform;
                //other.transform.parent = transform;
                other.transform.position = FoodPutPosition.transform.position;
                GlobalValues.Money += GlobalValues.FoodPrice;
                GotMoneySound.Play();
                MoneyText.text = string.Format("Money: {0}", GlobalValues.Money);
                StartCoroutine(CanPutFoodWaitTime());
                PFS.CanPickUp = true;
                CanPutFood = false;
            }
        }
    }

    IEnumerator CanPutFoodWaitTime()
    {
        yield return new WaitForSeconds(2.0f);
        FoodTransformLocation = FoodTransformLocationn.gameObject;
        Destroy(FoodTransformLocation);
        CanPutFood = true;
    }
}
