using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public time passed variable
    public float gameTimer = 0f;
    //public fixed time passed variable 
    public float fixedgameTimer = 0f;

    public GameObject myEnemy;
    public float spawnInterval = .5f;
    public float spawnTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add time passed between frames
        gameTimer += Time.deltaTime;
        
        //spawn enemy with time intervals
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0f;
            Instantiate(myEnemy);
            Debug.Log("Enemy Spawned");
        }
    }

    void FixedUpdate()
    {
        //add time passed between each physics frames
        fixedgameTimer += Time.fixedDeltaTime;
    }
}
