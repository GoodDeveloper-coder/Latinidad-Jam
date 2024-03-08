using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleDetectCollisionScript : MonoBehaviour
{
    public SpawnPeople SpawnPeopleScript;

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "People")
        {
            SpawnPeopleScript.PeopleCollisionIntersect = false;
        }
    }
}
