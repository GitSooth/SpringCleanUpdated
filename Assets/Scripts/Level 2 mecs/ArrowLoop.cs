using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLoop : MonoBehaviour
{
    public GameObject swicth;

    public Animator swicth1part1;
    public Animator swicth2part1;
    public Animator swicth3part1;
    public Animator swicth4part1;

    public bool press;
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
        if (collision.tag == "Player" && inside == false )
        {
            /*Passa verdadeiro para falsa e vice versa*/
            press = !press;
            inside = true;
            if(press==true)
            {
             swicth1part1.SetTrigger("");
            }

            else
            {
                swicth2part1.SetTrigger("");
            }
           
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Player"&&  inside == true)
        {
            inside = false;
        }
    }
}
