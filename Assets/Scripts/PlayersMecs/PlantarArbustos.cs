using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantarArbustos : MonoBehaviour
{
    public bool inPosition = false;
    
    public GameObject arbustos;
    Transform plantposiction;
    public List<GameObject> Treelist;
    int TreeCount = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Plant")
        {
            Debug.Log($"{collision.tag}");
            Debug.Log("inside");
            inPosition = true;
            plantposiction = collision.transform;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U) && inPosition == true)
        {

            GameObject treeObject = Instantiate(arbustos);
            treeObject.transform.parent = plantposiction;
            treeObject.SetActive(true);
            treeObject.transform.localPosition = new Vector3(0, 0, 0);
            Debug.Log("Planted tree");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Plant")
        {
            Debug.Log("left");
            inPosition = false;
        }
    }
}