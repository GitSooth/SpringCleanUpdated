using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabTrash : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform attackPoint;
    public GameObject trashObject;
    public float range = 0.5f;

    public bool grabbed;

    public LayerMask trashLayers;

    void Update()
    {
        Grab();
    }

    void Grab()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Collider2D trash = Physics2D.OverlapCircle(attackPoint.position, range, trashLayers);
            trash.transform.parent = attackPoint;
            trash.transform.position = attackPoint.position;
            grabbed = true;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            Collider2D trash = Physics2D.OverlapCircle(attackPoint.position, range, trashLayers);
            trash.transform.parent = null;
            grabbed = false;
		}
    }

    private void OnDrawGizmos()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, range);
    }
}
