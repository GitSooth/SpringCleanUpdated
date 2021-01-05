using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public string Nivel;
    public float health;
    public float[] position;

    public PlayerData(GameObject player)
    {
        Nivel = SceneManager.GetActiveScene().name;
        health = player.GetComponentInChildren<HealthBar>().slider.value;
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
