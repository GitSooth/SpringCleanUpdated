using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovement : MonoBehaviour
{
    public float moveSpeed;

    public Animator anim;
    public Transform player;
    public Transform attack;

    private void Start()
    {
        moveSpeed = 0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            moveSpeed = 5f;
            player.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            attack.transform.position = this.transform.position + new Vector3(1.0f, 0.0f, 0.0f);
            player.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveSpeed = 5f;
            player.position -= new Vector3(-Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            attack.transform.position = this.transform.position + new Vector3(-1.0f, 0.0f, 0.0f);
            player.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            moveSpeed = 5f;
            player.position += new Vector3(0.0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0.0f);
            attack.transform.position = this.transform.position + new Vector3(0.0f, 1f, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveSpeed = 5f;
            player.position -= new Vector3(0.0f, -Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0.0f);
            attack.transform.position = this.transform.position + new Vector3(0.0f, -1f, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            moveSpeed = 0f;
        }

        if (moveSpeed > 0)
        {
            anim.SetBool("Moving", true);
        }

        else anim.SetBool("Moving", false);
    }
}