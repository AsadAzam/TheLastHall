using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MapGenerator : MonoBehaviour
{

    public GameObject[] Tile;
    Vector3 nextSpawnPoint = new Vector3(-14, 0, 5);
    public static TextMeshProUGUI scoreLabel;

    public void SpawnTile() {
        int randomTile = Random.Range(0,5);
        GameObject temp = Instantiate(Tile[randomTile], nextSpawnPoint, Quaternion.Euler(0, 0, 90));
        nextSpawnPoint = temp.transform.GetChild(0).transform.position;
    }

    void Start() {
        scoreLabel = GameObject.FindGameObjectWithTag("CurrentScore").GetComponent<TextMeshProUGUI>();
        SpawnTile();
    }

    void Update() {
		scoreLabel.text = LoadSceneOnInput.score.ToString();
	}
}
