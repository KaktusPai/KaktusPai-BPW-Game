using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassthroughGlass : MonoBehaviour
{
    public PlayerMovement player;

    public Material Glass;
    public Material GlassThrough;

    // Update is called once per frame
    void Update()
    {
        if (player.currentJump == 2)
        {
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Renderer>().material = GlassThrough;
            transform.gameObject.layer = 0;
        } else
        {
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Renderer>().material = Glass;
            transform.gameObject.layer = 9;
        }
    }
}