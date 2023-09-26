using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public ChefManCookingScript CHMCS;

    //public PutFoodOnTableScript PFOTS;

    public GlobalValues GB;

    public playerMovement PlayerMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradePlayerSpeed()
    {
        if (GB.Money >= 5)
        {
            GB.Money -= 5f;
            PlayerMovementScript.moveSpeed += PlayerMovementScript.moveSpeed / 20;
        }
    }

    public void UpgradeCookingTime()
    {
        if (GB.Money >= 5)
        {
            GB.Money -= 5f;
            CHMCS.FoodCookingTime -= CHMCS.FoodCookingTime / 20;
        }
    }

    public void UpgradeSellingfood()
    {
        if (GB.Money >= 5)
        {
            GB.Money -= 5f;
            GB.FoodPrice += GB.FoodPrice / 20;
        }  
    }
}
