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
            GB.Money -= UpgradePlayerSpeedPrice;
           //UpgradePlayerSpeedText.text = string.Format("Cost: {0}", UpgradePlayerSpeedPrice);
            UpgradePlayerSpeedPrice += UpgradePlayerSpeedPrice / 4;
            PlayerMovementScript.moveSpeed += PlayerMovementScript.moveSpeed / 20;
        }
    }

    public void UpgradeCookingTime()
    {
        if (GB.Money >= UpgradeCookingTimePrice)
        {
           GB.Money -= UpgradeCookingTimePrice;
            //UpgradeCookingTimeText.text = string.Format("Cost: {0}", UpgradeCookingTimePrice);
            UpgradeCookingTimePrice += UpgradeCookingTimePrice / 4;
            CHMCS.FoodCookingTime -= CHMCS.FoodCookingTime / 20;
        }
    }

    public void UpgradeSellingfood()
    {
        if (GB.Money >= UpgradeSellingfoodPrice)
        {
            GB.Money -= UpgradeSellingfoodPrice;
            //UpgradeSellingfoodText.text = string.Format("Cost: {0}", UpgradeSellingfoodPrice);
            UpgradeSellingfoodPrice += UpgradeSellingfoodPrice / 4;
            GB.FoodPrice += GB.FoodPrice / 20;
        }  
    }

    public void UpgradePeopleStaingInCafeAfterFood()
    {
        if (GB.Money >= UpgradePeopleComeTimePrice)
        {
            GB.Money -= UpgradePeopleComeTimePrice;
            //UpgradePeopleStaingInCafeText.text = string.Format("Cost: {0}", UpgradePeopleStaingInCafePrice);
            UpgradePeopleComeTimePrice += UpgradePeopleComeTimePrice / 5;
            SpawnPeopleScript.PeopleSpawnTime -= SpawnPeopleScript.PeopleSpawnTime / 45;
        }
    }


    public void StartFateIn()
    {
        StartFate.SetActive(false);
    }

}
