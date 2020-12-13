using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player1, player2;
    private bool onPlayer1;

    // Start is called before the first frame update
    void Start()
    {
        player2.SetActive(false);
        onPlayer1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
            onPlayer1 = !onPlayer1;

        if (!onPlayer1)
        {
            player2.SetActive(true);
            player1.SetActive(false);
            transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y, player2.transform.position.z - 10);
        }
        else if(onPlayer1)
        {
            player2.SetActive(false);
            player1.SetActive(true);
            transform.position = new Vector3(player1.transform.position.x, player1.transform.position.y, player1.transform.position.z - 10);
        }
    }
}
