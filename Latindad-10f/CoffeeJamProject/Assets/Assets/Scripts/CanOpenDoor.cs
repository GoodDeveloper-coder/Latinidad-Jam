
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanOpenDoor : MonoBehaviour
{
    private bool BoolCanOpenDoor = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BoolCanOpenDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(1);
                Debug.Log("OpenDoor");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            BoolCanOpenDoor = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            BoolCanOpenDoor = false;
        }
    }
}
