using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesInteraction : MonoBehaviour
{
    public GameObject player;
    public bool trap;
    public bool inside;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Player")
        {
            Debug.Log("Inside wave");
            player.transform.position += new Vector3(0, 1f, 0);
        }
    }
}