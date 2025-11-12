using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Button NormalButton;
    public Button HardButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NormalButton.onClick.AddListener(NormalMode); // both of these make the button work lol (I think)
        HardButton.onClick.AddListener(HardMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NormalMode()
    {
        PlayerPrefs.SetInt("Difficulty", 0);
        SceneManager.LoadScene("Game");
        //starts the game on normal mode
    }

    public void HardMode()
    {
        PlayerPrefs.SetInt("Difficulty", 1);
        SceneManager.LoadScene("Game");
        //starts the game on hard mode
    }
}
