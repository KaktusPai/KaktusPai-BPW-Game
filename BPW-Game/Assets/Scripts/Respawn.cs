using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;

    void onTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
        Debug.Log("YOOOOOOOOOOOOOO");
    }
}
