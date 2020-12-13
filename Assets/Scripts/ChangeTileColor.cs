using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ChangeTileColor : MonoBehaviour
{
    public Transform position;
    public Tilemap tilemap;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            SetTileColor(Color.gray, new Vector3Int((int)position.position.x, (int)position.position.y, (int)position.position.z), tilemap);
        }
    }

    void SetTileColor(Color color, Vector3Int position, Tilemap tilemap)
    {
        tilemap.SetTileFlags(position, TileFlags.None);

        tilemap.SetColor(position, color);
    }
}
