using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public bool inPosition = false;
    
	void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Trash")
        {
            inPosition = true;

            Destroy(collider.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Trash")
            inPosition = false;
    }
}