using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesInteraction : MonoBehaviour
{
    public GameObject swicth;

    public Animator waves;

    public bool trap;
    public bool inside;
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
        if (collision.tag == "Player" && trap == false)
        {
            /*Passa verdadeiro para falsa e vice versa*/
          
            if (trap == true)
            {
                waves.SetTrigger("");
            }

            else
            {
                waves.SetTrigger("");
            }

        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Player" && inside == true)
        {
            inside = false;
        }
    }
}
