using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefManCookingScript : MonoBehaviour
{
    public GameObject Food1;
    public bool CanCook = true;

    public Animator anim;

    public GameObject[] Foods;

    public GameObject SpawnFoodPlace;

    public float FoodCookingTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CookingTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CookingTime()
    {

        if (CanCook)
        {
            anim.SetBool("Cook", true);
            yield return new WaitForSeconds(FoodCookingTime);
            Instantiate(Foods[Random.Range(0, Foods.Length)], SpawnFoodPlace.transform.position, Quaternion.identity);
            //Food1.SetActive(true);
            CanCook = false;
            anim.SetBool("Cook", false);
        }
        

        yield return new WaitForSeconds(2.0f);
        StartCoroutine(CookingTime());
    }
}
