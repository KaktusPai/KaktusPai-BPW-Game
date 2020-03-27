using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform1Toggle : MonoBehaviour
{
    public PlayerMovement player;

    // Update is called once per frame
    void Update()
    {
        if (player.platformToggle == false)
        {
            GetComponent<Collider>().enabled = !GetComponent<Collider>().enabled;
        } 
    }
}
