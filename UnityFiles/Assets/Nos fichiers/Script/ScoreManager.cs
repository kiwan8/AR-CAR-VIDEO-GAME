using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public CarBehaviour Car;
    public Text ScoreText;

    private void Update()
    {
        ScoreText.text = "Score: " + Car.Score; //okay
    }
    public void IncrementScore()
    {
        Car.Score++;
    }
    public void ResetGame()
    {
        Car.Score = 0;
        SceneManager.LoadScene("SampleScene");
    }

}