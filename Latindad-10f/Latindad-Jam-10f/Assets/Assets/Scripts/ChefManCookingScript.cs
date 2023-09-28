using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChefManCookingScript : MonoBehaviour
{
    public GameObject Food1;
    public bool CanCook = true;

    public Animator anim;

    public GameObject[] Foods;

    public GameObject SpawnFoodPlace;

    public float FoodCookingTime = 15f;

    public Scrollbar scrollbar;

    public AudioSource FoodCookedSound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CookingTime());
        StartCoroutine(ScrollbarTime());
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
            FoodCookedSound.Play();
            Instantiate(Foods[Random.Range(0, Foods.Length)], SpawnFoodPlace.transform.position, Quaternion.identity);
            //Food1.SetActive(true);
            CanCook = false;
            anim.SetBool("Cook", false);
        }

        yield return new WaitForSeconds(2.0f);
        StartCoroutine(CookingTime());
    }

    IEnumerator ScrollbarTime()
    {
        if (CanCook)
        {
            yield return new WaitForSeconds(FoodCookingTime / 10);
            scrollbar.size += 0.1f;
        }
        else if (!CanCook)
        {
            scrollbar.size = 0f;
        }

        yield return new WaitForSeconds(0.001f);
        StartCoroutine(ScrollbarTime());
    }
}
