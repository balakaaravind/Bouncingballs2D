using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject winText;
    public TextMeshProUGUI scoreText;

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
        if (score >= 5 )
        {
            Win();
        }
    }

    void Win()
    {
        winText.SetActive(true);

    }
    void Update()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene(0); 
    }
}
