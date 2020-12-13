using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public bool inPosition = false;
	public Score score;
    
	void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Trash")
        {
            inPosition = true;

            Destroy(collider.gameObject);

            foreach (GameObject obj in GetComponent<TrashManager>().trashList1)
            {
                if (obj.name == collider.name)
                {
                    GetComponent<TrashManager>().trashList1.Remove(obj);
					score.setscore(150);
                    GetComponent<TrashManager>().trashList1.Remove(obj);
					score.setscore(150);
				}
                else continue;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Trash")
            inPosition = false;
    }
}