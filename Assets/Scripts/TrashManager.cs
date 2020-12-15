using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TrashManager : MonoBehaviour
{
    [SerializeField]
    Tilemap map;
    public List<GameObject> trashList1, trashList2, trashList3, trashList4, trashList5, trashList6;
    public GameObject[] trash1, trash2, trash3, trash4, trash5, trash6;
    public LayerMask trashLayer;

    [SerializeField]
    private List<TileData> tileDatas;

    public Tile topLeft, botLeft, midTop, midBot, rightTop, rightBot;

    private Dictionary<TileBase, TileData> dataFromTiles;

	public Score score;

	private bool trash1Done, trash2Done, trash3Done, trash4Done, trash5Done, trash6Done;

	private void Awake()
    {
        dataFromTiles = new Dictionary<TileBase, TileData>();

        foreach (var tileData in tileDatas)
        {
            foreach (var tile in tileData.tiles)
            {
                dataFromTiles.Add(tile, tileData);
            }
        }
    }

    void Start()
    {
        trashList1 = new List<GameObject>();
        trashList2 = new List<GameObject>();
        trashList3 = new List<GameObject>();
        trashList4 = new List<GameObject>();
        trashList5 = new List<GameObject>();
        trashList6 = new List<GameObject>();

        foreach (GameObject trashLeft in trash1)
        {
            trashList1.Add(trashLeft);
			
        }

        foreach (GameObject trashLeft in trash2)
        {
            trashList2.Add(trashLeft);
			
		}

        foreach (GameObject trashLeft in trash3)
        {
            trashList3.Add(trashLeft);
			
		}

        foreach (GameObject trashLeft in trash4)
        {
            trashList4.Add(trashLeft);
			
		}

        foreach (GameObject trashLeft in trash5)
        {
            trashList5.Add(trashLeft);
		
		}

        foreach (GameObject trashLeft in trash6)
        {
            trashList6.Add(trashLeft);
		
		}
    }

    void Update()
    {
        foreach(GameObject go in trashList1)
        {
            if (go == null) {

				trashList1.Remove(go);
			score.setscore(150);

			}
            
		}

        foreach (GameObject go in trashList2)
        {
            if (go == null)
			{

				trashList2.Remove(go);
				score.setscore(150);

			}
		}

        foreach (GameObject go in trashList3)
        {
            if (go == null)
			{

				trashList3.Remove(go);
				score.setscore(150);

			}
		}

        foreach (GameObject go in trashList4)
        {
            if (go == null)
			{

				trashList4.Remove(go);
				score.setscore(150);

			}
		}

        foreach (GameObject go in trashList5)
        {
            if (go == null)
			{

				trashList5.Remove(go);
				score.setscore(150);

			}
		}

        foreach (GameObject go in trashList6)
        {
            if (go == null)
			{

				trashList6.Remove(go);
				score.setscore(150);

			}
		}

        if (trashList1.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-5, -2, 0);

			map.SetTile(gridPosition, topLeft);
			score.setscore(300);

			trash1Done =true;
        }

        if (trashList2.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-5, -4, 0);

			map.SetTile(gridPosition, botLeft);
			score.setscore(300);

			trash2Done = true;
		}

        if (trashList3.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-3, -2, 0);

	        map.SetTile(gridPosition, midTop);
	        score.setscore(300);

			trash3Done = true;
		}

        if (trashList4.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-3, -4, 0);

			map.SetTile(gridPosition, midBot);
			score.setscore(300);

			trash4Done = true;
		}

        if (trashList5.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-1, -2, 0);

			map.SetTile(gridPosition, rightTop);
			score.setscore(300);

			trash1Done = true;
		}

        if (trashList6.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-1, -4, 0);

		     map.SetTile(gridPosition, rightBot);
             score.setscore(300);

			trash1Done = true;
		}
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "LogMarker")
        {
            if(Input.GetKey(KeyCode.M))
            {
				collision.GetComponent<Sprite>();
            }
        }
    }
}