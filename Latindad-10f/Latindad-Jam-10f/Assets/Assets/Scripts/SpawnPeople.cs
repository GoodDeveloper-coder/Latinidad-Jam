
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeople : MonoBehaviour
{
    public GameObject[] People;
    public GameObject[] PeopleSpawnPosition;

    private GameObject SpawnedPeople;

    public GameObject TablesLocation;

    private int PeoplesRandomSpawnPos;

    public float PeopleSpawnTime = 25f;

    // Start is called before the first frame update
    void Start()
    {
        PeoplesRandomSpawnPos = Random.Range(0, PeopleSpawnPosition.Length);
        SpawnedPeople = Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[PeoplesRandomSpawnPos].transform.position, Quaternion.identity);
        SpawnedPeople.transform.parent = PeopleSpawnPosition[PeoplesRandomSpawnPos].transform;
        StartCoroutine(PeopleSpawnTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PeopleSpawnTimer()
    {

        PeoplesRandomSpawnPos = Random.Range(0, PeopleSpawnPosition.Length);
        yield return new WaitForSeconds(PeopleSpawnTime);
        SpawnedPeople = Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[PeoplesRandomSpawnPos].transform.position, Quaternion.identity);
        SpawnedPeople.transform.parent = PeopleSpawnPosition[PeoplesRandomSpawnPos].transform;
        StartCoroutine(PeopleSpawnTimer());
    }
}
