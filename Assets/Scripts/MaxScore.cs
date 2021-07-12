using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaxScore : MonoBehaviour
{

    int maxScore = LoadSceneOnInput.score;
    public static TextMeshProUGUI scoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        scoreLabel = GameObject.FindGameObjectWithTag("FinalScore").GetComponent<TextMeshProUGUI>();
        scoreLabel.text = "Score " + maxScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
