using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text scoreEasy;
    public Text scoreHard;
    public Text gemCollector;

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
        SceneManager.LoadScene("DoubleTrouble");
    }
    public void Hard()
    {
        SceneManager.LoadScene("TripleSurge");
    }
    public void GemCollector()
    {
        SceneManager.LoadScene("GemCollector");
    }
    public void Shop()
    {
        SceneManager.LoadScene("store");
    }

    private void Start()
    {
        scoreEasy.text = PlayerPrefs.GetFloat("DoubleTroubleScore", 0).ToString();
        scoreHard.text = PlayerPrefs.GetFloat("TripleSurgeScore", 0).ToString();
        gemCollector.text = PlayerPrefs.GetFloat("GemCollectorScore", 0).ToString();

        currency.text = PlayerPrefs.GetFloat("currency", 0).ToString();

        PlayerPrefs.SetInt("skin", 1);
    }

}
