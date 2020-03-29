using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform1Toggle : MonoBehaviour
{
    public PlayerMovement player;

    public Material Purple;
    public Material PurpleGlass;

    // Update is called once per frame
    void Update()
    {
        if (player.platformToggle == true)
        {
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Renderer>().material = Purple;
            transform.gameObject.layer = 9;
        } else
        {
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Renderer>().material = PurpleGlass;
            transform.gameObject.layer = 0;
        }
    }
}