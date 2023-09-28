using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public ChefManCookingScript CHMCS;

    //public PutFoodOnTableScript PFOTS;

    public GlobalValues GB;

    public playerMovement PlayerMovementScript;

    public SpawnPeople SpawnPeopleScript;

    public GameObject StartFate;

    public float UpgradePlayerSpeedPrice = 5f;

    [SerializeField] private TextMeshProUGUI UpgradePlayerSpeedText;

    public float UpgradeCookingTimePrice = 5f;

    [SerializeField] private TextMeshProUGUI UpgradeCookingTimeText;

    public float UpgradeSellingfoodPrice = 5f;

    [SerializeField] private TextMeshProUGUI UpgradeSellingfoodText;

    public float UpgradePeopleComeTimePrice = 10f;

    [SerializeField] private TextMeshProUGUI UpgradePeopleStaingInCafeText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpgradePlayerSpeedText.text = string.Format("Cost: {0}", UpgradePlayerSpeedPrice);
        UpgradeCookingTimeText.text = string.Format("Cost: {0}", UpgradeCookingTimePrice);
        UpgradeSellingfoodText.text = string.Format("Cost: {0}", UpgradeSellingfoodPrice);
        UpgradePeopleStaingInCafeText.text = string.Format("Cost: {0}", UpgradePeopleComeTimePrice);
    }

    public void UpgradePlayerSpeed()
    {
        if (GB.Money >= UpgradePlayerSpeedPrice)
        {
            UpgradePlayerSpeedPrice += UpgradePlayerSpeedPrice / 4;
           //UpgradePlayerSpeedText.text = string.Format("Cost: {0}", UpgradePlayerSpeedPrice);
            GB.Money -= UpgradePlayerSpeedPrice;
            PlayerMovementScript.moveSpeed += PlayerMovementScript.moveSpeed / 20;
        }
    }

    public void UpgradeCookingTime()
    {
        if (GB.Money >= UpgradeCookingTimePrice)
        {
            UpgradeCookingTimePrice += UpgradeCookingTimePrice / 4;
           //UpgradeCookingTimeText.text = string.Format("Cost: {0}", UpgradeCookingTimePrice);
            GB.Money -= UpgradeCookingTimePrice;
            CHMCS.FoodCookingTime -= CHMCS.FoodCookingTime / 20;
        }
    }

    public void UpgradeSellingfood()
    {
        if (GB.Money >= UpgradeSellingfoodPrice)
        {
            UpgradeSellingfoodPrice += UpgradeSellingfoodPrice / 4;
            //UpgradeSellingfoodText.text = string.Format("Cost: {0}", UpgradeSellingfoodPrice);
            GB.Money -= UpgradeSellingfoodPrice;
            GB.FoodPrice += GB.FoodPrice / 20;
        }  
    }

    public void UpgradePeopleStaingInCafeAfterFood()
    {
        if (GB.Money >= UpgradePeopleComeTimePrice)
        {
            UpgradePeopleComeTimePrice += UpgradePeopleComeTimePrice / 5;
            //UpgradePeopleStaingInCafeText.text = string.Format("Cost: {0}", UpgradePeopleStaingInCafePrice);
            GB.Money -= UpgradeSellingfoodPrice;
            SpawnPeopleScript.PeopleSpawnTime -= SpawnPeopleScript.PeopleSpawnTime / 45;
        }
    }


    public void StartFateIn()
    {
        StartFate.SetActive(false);
    }

}
