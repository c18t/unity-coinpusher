using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerScript : MonoBehaviour {

    public GameObject scoreText;
    ScoreScript scoreScript;
    AudioSource audioSource;

    void Start()
    {
        scoreScript = scoreText.GetComponent<ScoreScript>();
        audioSource = this.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            scoreScript.addScore(2);
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
