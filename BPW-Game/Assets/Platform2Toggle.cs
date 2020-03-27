using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2Toggle
    : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Collider>().enabled = !GetComponent<Collider>().enabled;
        }
    }
}
