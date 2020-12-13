using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovement : MonoBehaviour
{
    public Animator anim;

    public int moveSpeed = 5;

    public Transform player;
    public Transform attack;

    void Update()
    { 
        Vector3 characterScale = transform.localScale;

        if (Input.GetKey(KeyCode.D))
        {
            player.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            attack.transform.position = this.transform.position + new Vector3(1.0f, 0.0f, 0.0f);

            player.rotation = Quaternion.AngleAxis(90f, new Vector3(0.0f, 1.0f, 0.0f));
            anim.SetFloat("Speed", 1f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.position -= new Vector3(-Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            attack.transform.position = this.transform.position + new Vector3(-1.0f, 0.0f, 0.0f);
            player.rotation = Quaternion.AngleAxis(90f, new Vector3(0.0f, -1.0f, 0.0f));
            anim.SetFloat("Speed", 1f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.position += new Vector3(0.0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0.0f);
            attack.transform.position = this.transform.position + new Vector3(0.0f, 1f, 0.0f);
            player.rotation = Quaternion.AngleAxis(0f, new Vector3(0f, -1f, 0.0f));
            anim.SetFloat("Speed", 1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.position -= new Vector3(0.0f, -Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0.0f);
            attack.transform.position = this.transform.position + new Vector3(0.0f, -1f, 0.0f);
            player.rotation = Quaternion.AngleAxis(180f, new Vector3(0f, 1f, 0.0f));
            anim.SetFloat("Speed", 1f);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetFloat("Speed", 0f);
        }
    }
}