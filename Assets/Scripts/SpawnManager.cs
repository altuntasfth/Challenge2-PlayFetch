using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balls;

    private float startDelay = 1.0f;
    private float spawnInterval = 3.0f;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BallSpawner", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BallSpawner()
    {
        float ballXPos = Random.Range(spawnLimitXLeft, spawnLimitXRight);
        int whichBall = Random.Range(0, 3);
        Vector3 ballPos = new Vector3(ballXPos, 32, 0);

        Instantiate(balls[whichBall], ballPos, balls[whichBall].transform.rotation);
    }
}
