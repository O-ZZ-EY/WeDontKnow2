using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class patternspawner : MonoBehaviour
{
    private float maxTime = 8f;
    public GameObject[] patternPrefabs;
    public GameObject[] patternPrefabsHard;

    private float timer;

    void Start()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0) { SpawnPattern(); } // If the normal button was pressed, the difficulty int is set to 0. Hard mode sets it to 1.
        else if (PlayerPrefs.GetInt("Difficulty") == 1) { SpawnPatternHard(); }
        //kicks off code to start spawning patterns
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            if (PlayerPrefs.GetInt("Difficulty") == 0) { SpawnPattern(); timer = 0; }
            else if (PlayerPrefs.GetInt("Difficulty") == 1) { SpawnPatternHard(); timer = 0; }
            //when even the timer hits 0, a new pattern will be spawned
        }
        timer += Time.deltaTime;
        
    }

    private void SpawnPattern()
    {
        int randPattern = Random.Range(0, patternPrefabs.Length);
        //randomly selects pattern from an array of prefabs 
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //marks the position of where itll spawn
        Instantiate(patternPrefabs[randPattern], spawnPos, Quaternion.identity);
        //actually spawns/instantiates the random pattern
    }

    private void SpawnPatternHard()
    {
        int randPattern = Random.Range(0, patternPrefabsHard.Length);
        //randomly selects pattern from an array of prefabs 
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //marks the position of where itll spawn
        Instantiate(patternPrefabsHard[randPattern], spawnPos, Quaternion.identity);
        //actually spawns/instantiates the random pattern
    }
}
