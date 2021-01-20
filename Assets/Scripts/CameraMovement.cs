using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player1;
    public float distance = 3f;

    [SerializeField]
    float leftLimit, rightLimit, upLimit, downLimit;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player1.transform.position.x, player1.transform.position.y, player1.transform.position.z - distance);

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, downLimit, upLimit),
            transform.position.z
            );
    }
}