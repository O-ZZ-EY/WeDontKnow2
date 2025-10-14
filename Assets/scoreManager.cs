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
       
    }

    // Update is called once per frame
    void Update()
    {
        score += pointsPerSecond * Time.deltaTime;
    }
}
