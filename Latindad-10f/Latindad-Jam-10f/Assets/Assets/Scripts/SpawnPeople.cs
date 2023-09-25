
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeople : MonoBehaviour
{
    public GameObject[] People;
    public GameObject[] PeopleSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[Random.Range(0, PeopleSpawnPosition.Length)].transform.position, Quaternion.identity);
        StartCoroutine(PeopleSpawnTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PeopleSpawnTimer()
    {


        yield return new WaitForSeconds(20.0f);
        Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[Random.Range(0, PeopleSpawnPosition.Length)].transform.position, Quaternion.identity);
        StartCoroutine(PeopleSpawnTimer());
    }
}
