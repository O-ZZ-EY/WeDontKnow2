using UnityEngine;

public class patternspawner : MonoBehaviour
{
    private float maxTime = 8f;
    public GameObject[] patternPrefabs;

    private float timer;

    void Start()
    {
        SpawnPattern();
        //kicks off code to start spawning patterns
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            SpawnPattern();
            timer = 0;
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
}
