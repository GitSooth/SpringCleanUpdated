using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Transform Tile;
	public Transform Trash;
	public Transform Plant;

	public Text score;
	public int scorevalue;

	public void setscore(int value)
	{
		scorevalue += value;
		score.text = "Score: " + scorevalue;
	}

	void Update()
	{
		//score.text = Trash.position.z.ToString("0");
	}

}