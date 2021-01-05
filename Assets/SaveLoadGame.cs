using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadGame : MonoBehaviour
{
    public GameObject player;

    public void SaveGame()
    {
        SaveSystem.SaveGame(player);
    }

    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadGame();

        SceneManager.LoadScene(data.Nivel);
        player.GetComponent<HealthBar>().slider.value = data.health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        player.transform.position = position;
    }
}
