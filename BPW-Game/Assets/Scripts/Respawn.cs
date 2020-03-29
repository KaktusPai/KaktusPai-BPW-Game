using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<CharacterController>().enabled = false;
        Debug.Log("Triggered");
        player.transform.position = respawnPoint.transform.position;
        player.GetComponent<CharacterController>().enabled = true;
    }
}
