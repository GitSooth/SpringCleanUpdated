using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWrap : MonoBehaviour
{
    public GameObject Player;
    public GameObject Teleport;

    public GameObject teleport;
    public bool wrap;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Player" && wrap == false)
        {
            collision.gameObject.transform.position = teleport.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Player" && wrap == true)
        {
            wrap = false;
        }
    }
}