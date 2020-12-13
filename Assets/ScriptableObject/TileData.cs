using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum TileType
{
    grass,
    road,
    brick,
    dust
}

[CreateAssetMenu]
public class TileData : ScriptableObject
{
    public TileBase[] tiles;
    public TileType tileType;
}
