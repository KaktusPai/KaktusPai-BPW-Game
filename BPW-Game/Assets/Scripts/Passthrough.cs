using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passthrough : MonoBehaviour
{
    public PlayerMovement player;

    public Material White;
    public Material Offwhite;

    // Update is called once per frame
    void Update()
    {
        if (player.currentJump == 2)
        {
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Renderer>().material = Offwhite;
            transform.gameObject.layer = 0;
        } else
        {
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Renderer>().material = White;
            transform.gameObject.layer = 9;
        }
    }
}