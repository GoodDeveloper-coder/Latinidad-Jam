using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefManPatruleScript : MonoBehaviour
{
    public float speed;

    public Transform[] moveSpots;

    private int randomSpots;

    private float waitTime;
    public float startWaitTime;

    public ChefManCookingScript CHMCS;

    // Start is called before the first frame update
    void Start()
    {
        randomSpots = Random.Range(0, moveSpots.Length);
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (CHMCS.CanCook)
        {
            transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpots].position, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, moveSpots[randomSpots].position) < 0.2f)
            {
                if (waitTime <= 0)
                {
                    randomSpots = Random.Range(0, moveSpots.Length);
                    waitTime = startWaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
    }
}
