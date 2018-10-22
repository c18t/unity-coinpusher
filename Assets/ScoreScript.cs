using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public int initScore;
    int currentScore;
    Text scoreText;

	// Use this for initialization
	void Start () {
        currentScore = initScore;
        scoreText = this.GetComponent<Text>();

        printScore(initScore);
	}

    public void subScore(int n)
    {
        currentScore -= n;
        printScore(currentScore);
    }

    public void addScore(int n)
    {
        currentScore += n;
        printScore(currentScore);
    }

    public void printScore(int n)
    {
        scoreText.text = n.ToString();
    }
}
