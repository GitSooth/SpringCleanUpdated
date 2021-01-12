using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blower : MonoBehaviour
{
    public GameObject player;
    public Transform point;
    public float range = 2f;
    public float strength = 0.035f;
    public LayerMask trashLayers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
            Blow();
    }

    void Blow()
    {
        Collider2D[] Trash = Physics2D.OverlapCircleAll(point.position, range, trashLayers);

        foreach (Collider2D trash in Trash)
        {
            if (trash.transform.parent == point)
            {
                trash.transform.position = point.position;
            }
            else
            {
                Vector3 direction = trash.transform.position - this.gameObject.transform.position;
                trash.transform.position += direction * strength;
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (point == null)
            return;

        Gizmos.DrawWireSphere(point.position, range);
    }
}
