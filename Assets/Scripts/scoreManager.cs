using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public float score = 0f;
    public float pointsPerSecond = 13f;
    
    void Start()
    {
        scoreText.text = "Score:" + score.ToString();
       //i did something wrong here I'm not sure what.
    }

    // Update is called once per frame
    void Update()
    {
        score += pointsPerSecond * Time.deltaTime;
        //the score is based on how long the player survives for, each second is x points, in this case 13
    }
}
