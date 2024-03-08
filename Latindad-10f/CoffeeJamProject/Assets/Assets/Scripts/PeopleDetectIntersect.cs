using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleDetectIntersect : MonoBehaviour
{

    private SpawnPeople SpawnPeopleScript;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPeopleScript = GameObject.Find("Tables").GetComponent<SpawnPeople>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "People")
        {
            SpawnPeopleScript.PeopleCollisionIntersect = true;
            Debug.Log("PeopleCollisionIntersectEnter");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "People")
        {
            SpawnPeopleScript.PeopleCollisionIntersect = false;
            Debug.Log("PeopleCollisionIntersectExit");
        }
    }
}