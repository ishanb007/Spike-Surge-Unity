using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text scoreEasy;
    public Text scoreHard;

    public Text currency;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Easy()
    {
        SceneManager.LoadScene("CoreProgramm");
    }
    public void Hard()
    {
        SceneManager.LoadScene("CoreProgramm 1");
    }
    public void Shop()
    {
        SceneManager.LoadScene("store");
    }

    private void Start()
    {
        scoreEasy.text = PlayerPrefs.GetFloat("EasyScore", 0).ToString();
        scoreHard.text = PlayerPrefs.GetFloat("HardScore", 0).ToString();

        currency.text = PlayerPrefs.GetFloat("currency", 0).ToString();

        PlayerPrefs.SetInt("skin", 1);
    }

}
