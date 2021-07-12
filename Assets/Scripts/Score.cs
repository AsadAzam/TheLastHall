using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private GameObject playerTransform;
    int maxScore = 0;

    void Start() {
        playerTransform = GameObject.FindGameObjectWithTag("FollowCamera");
    }

    // Update is called once per frame
    void Update() {
        if (maxScore < -(int)playerTransform.transform.position.x - 1) {
            maxScore = -(int)playerTransform.transform.position.x - 1;
        }
        LoadSceneOnInput.score = maxScore;

        if (playerTransform.transform.position.y < -15f) {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
