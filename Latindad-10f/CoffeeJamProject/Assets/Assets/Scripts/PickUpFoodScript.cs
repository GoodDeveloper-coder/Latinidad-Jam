using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFoodScript : MonoBehaviour
{
    //public GameObject food;
    public bool CanPickUp = true;

    public ChefManCookingScript ChefManScript;

    public GlobalValues GlobalValues;

    public AudioSource PickUpFoodSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E)) PickUp();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            if (CanPickUp) {
                PickUpFoodSound.Play();
                other.transform.parent = transform;
                ChefManScript.CanCook = true;
                other.transform.position = this.transform.position;
                Debug.Log("CanPickUp");
                CanPickUp = false;
            }
        }

        if (other.gameObject.tag == "People")
        {
            GlobalValues.EnterInPeopleZone = true;
        }
        else
        {
            GlobalValues.EnterInPeopleZone = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            CanPickUp = false;
            Debug.Log("Can'tPickUp");
        }
    }
    /*
    void PickUp()
    {
        if (CanPickUp)
        {
            //food.transform.parent = transform;
            //food.transform.position = this.transform.position;
            ChefManScript.CanCook = true;
        }
    }
    */
}
