using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class TrashManager : MonoBehaviour
{
    [SerializeField]
    Tilemap map;
    public List<GameObject> trashList1, trashList2, trashList3, trashList4, trashList5, trashList6;
    public GameObject[] trash1, trash2, trash3, trash4, trash5, trash6;
    public LayerMask trashLayer;

    public Text text;

    public Vector3Int cLT, cLB, cMT, cMB, cRT, cRB;

    [SerializeField]
    private List<TileData> tileDatas;

    public Tile topLeft, botLeft, midTop, midBot, rightTop, rightBot;

    private Dictionary<TileBase, TileData> dataFromTiles;

    private bool trash1Done = false,
        trash2Done = false,
        trash3Done = false,
        trash4Done = false,
        trash5Done = false,
        trash6Done = false;

    private bool points1added = false,
        points2added = false,
        points3added = false,
        points4added = false,
        points5added = false,
        points6added = false;

    public int pontos = 0;

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
        foreach (GameObject go in trashList1)
        {
            if (go == null)
            {
                trashList1.Remove(go);
                pontos += 15;
                text.text = ($"Score: {pontos}");
            }
        }

        foreach (GameObject go in trashList2)
        {
            if (go == null)
            {
                trashList2.Remove(go);
                pontos += 15;
                text.text = ($"Score: {pontos}");
            }
        }

        foreach (GameObject go in trashList3)
        {
            if (go == null)
            {
                trashList3.Remove(go);
                pontos += 15;
                text.text = ($"Score: {pontos}");
            }
        }

        foreach (GameObject go in trashList4)
        {
            if (go == null)
            {
                trashList4.Remove(go);
                pontos += 15;
                text.text = ($"Score: {pontos}");
            }
        }

        foreach (GameObject go in trashList5)
        {
            if (go == null)
            {
                trashList5.Remove(go);
                pontos += 15;
                text.text = ($"Score: {pontos}");
            }
        }

        foreach (GameObject go in trashList6)
        {
            if (go == null)
            {
                trashList6.Remove(go);
                pontos += 15;
                text.text = ($"Score: {pontos}");
            }
        }

        if (trashList1.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(cLT.x, cLT.y, cLT.z);

            map.SetTile(gridPosition, topLeft);

            if (!points1added)
            {
                pontos += 100;
                text.text = ($"Score: {pontos}");
                points1added = true;
            }
            else
            {

            }

            trash1Done = true;
        }

        if (trashList2.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(cLB.x, cLB.y, cLB.z);

            map.SetTile(gridPosition, botLeft);

            if (!points2added)
            {
                pontos += 100;
                text.text = ($"Score: {pontos}");
                points2added = true;
            }
            else
            {

            }

            trash2Done = true;
        }

        if (trashList3.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(cMT.x, cMT.y, cMT.z);

            map.SetTile(gridPosition, midTop);

            if (!points3added)
            {
                pontos += 100;
                text.text = ($"Score: {pontos}");
                points3added = true;
            }
            else
            {

            }

            trash3Done = true;
        }

        if (trashList4.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(cMB.x, cMB.y, cMB.z);

            map.SetTile(gridPosition, midBot);

            if (!points4added)
            {
                pontos += 100;
                text.text = ($"Score: {pontos}");
                points4added = true;
            }
            else
            {

            }

            trash4Done = true;
        }

        if (trashList5.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(cRT.x, cRT.y, cRT.z);

            map.SetTile(gridPosition, rightTop);

            if (!points5added)
            {
                pontos += 100;
                text.text = ($"Score: {pontos}");
                points5added = true;
            }
            else
            {

            }


            trash5Done = true;
        }

        if (trashList6.Count == 0)
        {
            Vector3Int gridPosition = new Vector3Int(cRB.x, cRB.y, cRB.z);

            map.SetTile(gridPosition, rightBot);

            if (!points6added)
            {
                pontos += 100;
                text.text = ($"Score: {pontos}");
                points6added = true;
            }
            else
            {

            }

            trash6Done = true;
        }
    }
}