using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player1;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player1.transform.position.x, player1.transform.position.y, player1.transform.position.z - 10f);
    }
}