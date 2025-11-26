using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public float score = 0f;
    public float pointsPerSecond = 1f; // this probably isnt doing anything lol
    public GameObject Player;
    public bool isDead;

    void Start()
    {
        score = 0f;
    }

    // Update is called once per frame
    void Update()
    {
            isDead = Player.GetComponent<playerMovement>().isDead;

        if (isDead == false)
        {
            score += pointsPerSecond * Time.deltaTime;
            Mathf.RoundToInt(score);
            scoreText.text = "Score: " + score.ToString("F0");
        //the score is based on how long the player survives for, each second is x points, in this case 13 // well its not 13 anymore
        }
    }
}
