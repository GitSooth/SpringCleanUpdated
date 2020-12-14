using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public Sprite tree;
    public bool inPosition;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.tag);
    }

    //void OnTriggerExit2D(Collider2D collider)
    //{
    //    if (collider.tag == "Player")
    //        inPosition = false;
    //}
}