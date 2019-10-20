using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    
    public TextMeshProUGUI ScoreText;
    public int score;
    

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        PlayerPrefs.SetInt("CurrentScore", score);

        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
