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
            if (go == null)
                trashList1.Remove(go);
        }

        foreach (GameObject go in trashList2)
        {
            if (go == null)
                trashList2.Remove(go);
        }

        foreach (GameObject go in trashList3)
        {
            if (go == null)
                trashList3.Remove(go);
        }

        foreach (GameObject go in trashList4)
        {
            if (go == null)
                trashList4.Remove(go);
        }

        foreach (GameObject go in trashList5)
        {
            if (go == null)
                trashList5.Remove(go);
        }

        foreach (GameObject go in trashList6)
        {
            if (go == null)
                trashList6.Remove(go);
        }

        if (trashList1.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-5, -2, 0);

            map.SetTile(gridPosition, topLeft);
        }

        if (trashList2.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-5, -4, 0);

            map.SetTile(gridPosition, botLeft);
        }

        if (trashList3.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-3, -2, 0);

            map.SetTile(gridPosition, midTop);
        }

        if (trashList4.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-3, -4, 0);

            map.SetTile(gridPosition, midBot);
        }

        if (trashList5.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-1, -2, 0);

            map.SetTile(gridPosition, rightTop);
        }

        if (trashList6.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(-1, -4, 0);

            map.SetTile(gridPosition, rightBot);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "LogMarker")
        {
            if(Input.GetKey(KeyCode.M))
            {
                collision.GetComponent<Sprite>()
            }
        }
    }
}