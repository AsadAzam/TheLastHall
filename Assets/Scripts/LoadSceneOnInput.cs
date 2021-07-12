using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour
{

    public static string sceneName;

    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    public void OnCheck()
    {
        sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "TitleScene") {
            SceneManager.LoadScene("BaseScene");
        } else if (sceneName == "GameOverScene") {
            SceneManager.LoadScene("TitleScene");
        }
	}
}
