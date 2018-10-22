using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    float moveSpeed = 2.0f;
    Rigidbody rb;
    public GameObject coin;
    public GameObject leftWall;
    public GameObject rightWall;
    float leftWallPositionX;
    float rightWallPositionX;

    public GameObject scoreText;
    ScoreScript scoreScript;

    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
        leftWallPositionX = leftWall.transform.position.x;
        rightWallPositionX = rightWall.transform.position.x;
        scoreScript = scoreText.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update () {
        float x = Input.GetAxis("Horizontal");
        Vector3 directon = new Vector3(x, 0, 0);
        rb.velocity = directon * moveSpeed;
        Vector3 currentPosition = this.transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x, leftWallPositionX, rightWallPositionX);
        this.transform.position = currentPosition;

        if (Input.GetKeyDown("space"))
        {
            Instantiate(coin, this.transform.position, this.transform.rotation);
            scoreScript.subScore(1);
        }
	}
}
