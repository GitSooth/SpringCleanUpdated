using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovement : MonoBehaviour
{
    public float moveSpeed;
    public float maxSpeed = 5f;

    public AudioManager audio;
    public Animator anim;
    public Transform player;
    public Transform attack;
    public Transform attackAnchor;

    private void Start()
    {
        moveSpeed = 0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            moveSpeed = maxSpeed;
            player.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            attack.transform.position = attackAnchor.position;
            player.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveSpeed = maxSpeed;
            player.position -= new Vector3(-Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            attack.transform.position = attackAnchor.position;
            player.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            moveSpeed = maxSpeed;
            player.position += new Vector3(0.0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveSpeed = maxSpeed;
            player.position -= new Vector3(0.0f, -Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0.0f);

        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            moveSpeed = 0f;
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            audio.Play("feet");
        else if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.S) && Input.GetKeyUp(KeyCode.D))
            audio.Stop("feet");

        if (moveSpeed != 0)
        {
            anim.SetBool("Moving", true);
        }

        else anim.SetBool("Moving", false);
    }
}