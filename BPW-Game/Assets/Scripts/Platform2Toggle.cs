using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2Toggle : MonoBehaviour
{
    public PlayerMovement player;

    public Material Pink;
    public Material PinkGlass;

    // Update is called once per frame
    void Update()
    {
        if (player.platformToggle == false)
        {
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Renderer>().material = Pink;
            transform.gameObject.layer = 9;
        } else
        {
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Renderer>().material = PinkGlass;
            transform.gameObject.layer = 0;
        }
    }
}
