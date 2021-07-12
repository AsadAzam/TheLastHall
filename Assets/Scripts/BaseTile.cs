using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTile : MonoBehaviour
{

    MapGenerator mapGenerator;
    
    // Start is called before the first frame update
    void Start() {
        mapGenerator = GameObject.FindObjectOfType<MapGenerator>();
    }

    void OnTriggerEnter(Collider other) {
        mapGenerator.SpawnTile();
    }

    void OnTriggerExit (Collider other) {
        Destroy(gameObject, 1);
    }
}
