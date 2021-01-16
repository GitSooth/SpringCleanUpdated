using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public string Nivel;

    public PlayerData()
    {
        Nivel = SceneManager.GetActiveScene().name;
    }
}
