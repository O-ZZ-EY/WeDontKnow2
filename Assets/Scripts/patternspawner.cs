using UnityEngine;

public class patternspawner : MonoBehaviour
{
    private float maxTime = 8f;
    public GameObject[] patternPrefabs;

    private float timer;

    void Start()
    {
        SpawnPattern();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            SpawnPattern();
            timer = 0;
        }
        timer += Time.deltaTime;
        
    }

    private void SpawnPattern()
    {
        int randPattern = Random.Range(0, patternPrefabs.Length); 
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        Instantiate(patternPrefabs[randPattern], spawnPos, Quaternion.identity);
    }
}
