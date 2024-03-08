
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

    public bool PeopleCollisionIntersect = false;

    //private bool needCheckPeopleLocation = true;

    // Start is called before the first frame update

    int i = 0;

    private bool NeedShuffle = true;
    void Start()
    {
        /*
        PeoplesRandomSpawnPos = Random.Range(0, PeopleSpawnPosition.Length);
        SpawnedPeople = Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[PeoplesRandomSpawnPos].transform.position, Quaternion.identity);
        SpawnedPeople.transform.parent = PeopleSpawnPosition[PeoplesRandomSpawnPos].transform;
        */
        StartCoroutine(PeopleSpawnTimer());
        Shuffle(OcupatedLocations);
    }

    // Update is called once per frame
    void Update()
    {
        if (PeopleCollisionIntersect)
        {
            Destroy(SpawnedPeople);
            StartCoroutine(PeopleSpawnTimer());
            Debug.Log("Destroyed People");
        }
        else
        {
            Debug.Log("No Destroyed People");
        }
    }

    IEnumerator PeopleSpawnTimer()
    {
        /*
        if (needCheckPeopleLocation)
        {
            if (OcupatedLocations != null)
            {
                PeoplesRandomSpawnPos = Random.Range(0, PeopleSpawnPosition.Length);


                for (int i = 0; i < OcupatedLocations.Count; i++)
                {
                    if (PeoplesRandomSpawnPos == OcupatedLocations[i])
                    {
                        //OcupatedLocations.Add(PeoplesRandomSpawnPos);
                        //PeoplesRandomSpawnPos = Random.Range(0, PeopleSpawnPosition.Length);
                        StartCoroutine(PeopleSpawnTimer());
                        Debug.Log("Again");
                    }
                    else
                    {
                        OcupatedLocations.Add(PeoplesRandomSpawnPos);
                        yield return new WaitForSeconds(PeopleSpawnTime);
                        SpawnedPeople = Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[PeoplesRandomSpawnPos].transform.position, Quaternion.identity);
                        SpawnedPeople.transform.parent = PeopleSpawnPosition[PeoplesRandomSpawnPos].transform;
                        StartCoroutine(PeopleSpawnTimer());
                        Debug.Log("Maked");
                    }
                }
            }
            else
            {
                OcupatedLocations.Add(PeoplesRandomSpawnPos);
                yield return new WaitForSeconds(PeopleSpawnTime);
                SpawnedPeople = Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[PeoplesRandomSpawnPos].transform.position, Quaternion.identity);
                SpawnedPeople.transform.parent = PeopleSpawnPosition[PeoplesRandomSpawnPos].transform;
                StartCoroutine(PeopleSpawnTimer());
                Debug.Log("Maked");
            }
        }
        */

        //PeoplesRandomSpawnPos = Random.Range(0, PeopleSpawnPosition.Length);
        //OcupatedLocations.Add(PeoplesRandomSpawnPos);


        PeoplesRandomSpawnPos = Random.Range(0, PeopleSpawnPosition.Length);
    
        i++;

        if (i >= OcupatedLocations.Count)
        {
            Shuffle(OcupatedLocations);
            i = 0;
            i++;
        }

        yield return new WaitForSeconds(PeopleSpawnTime);
        //SpawnedPeople = Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[PeoplesRandomSpawnPos].transform.position, Quaternion.identity);

        Debug.Log("After Shuffle => " + string.Join(", ", OcupatedLocations));
        Debug.Log("After Shuffle => " + string.Join(", ", OcupatedLocations[i]));
        SpawnedPeople = Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[OcupatedLocations[i]].transform.position, Quaternion.identity);
        //GameObject SpawnedPeople = Instantiate(People[Random.Range(0, People.Length)], PeopleSpawnPosition[PeoplesRandomSpawnPos].transform.position, Quaternion.identity);
        //SpawnedPeople.transform.parent = PeopleSpawnPosition[PeoplesRandomSpawnPos].transform;
        SpawnedPeople.transform.parent = PeopleSpawnPosition[OcupatedLocations[i]].transform;
        StartCoroutine(PeopleSpawnTimer());
    }


    List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


    List<int> OcupatedLocations = new List<int> {1, 2, 3, 4, 5, 6, 7};

    void Shuffle<T>(List<T> inputList)
    {
        for (int i = 0; i < inputList.Count - 1; i++)
        {
            T temp = inputList[i];
            int rand = Random.Range(i, inputList.Count);
            inputList[i] = inputList[rand];
            inputList[rand] = temp;
        }
    }
}
