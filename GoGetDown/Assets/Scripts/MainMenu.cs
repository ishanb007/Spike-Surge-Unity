using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject firstScreen;
    public GameObject secondScreen;

    private AudioSource bgm;
    
    public Text scoreEasy;
    public Text scoreHard;
    public Text gemCollector;
    public Text trickOrTreat;

    public Text currency;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void GameStart()
    {
        firstScreen.SetActive(false);
        secondScreen.SetActive(true);
    }
    public void BackToMain()
    {
        secondScreen.SetActive(false);
        firstScreen.SetActive(true);
    }


    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/incessant_games");
    }
    public void Ratings()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.Incessant.SpikeSurge");
    }
    public void Shop()
    {
        SceneManager.LoadScene("store");
    }
    public void LearnScreen()
    {
        SceneManager.LoadScene("LearnScreen");
    }
    public void AudioToggle(){
        bgm = GetComponent<AudioSource>();
        bgm.enabled = !bgm.enabled;
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
        SceneManager.LoadScene("Gem Collector");
    }
    public void TrickTreat()
    {
        SceneManager.LoadScene("TrickOrTreat");
    }
    public void ThemesScreen()
    {
        SceneManager.LoadScene("ThemesScreen");
    }


    private void Start()
    {
        scoreEasy.text = PlayerPrefs.GetFloat("DoubleTroubleScore", 0).ToString();
        scoreHard.text = PlayerPrefs.GetFloat("TripleSurgeScore", 0).ToString();
        gemCollector.text = PlayerPrefs.GetFloat("GemCollectorScore", 0).ToString();
        trickOrTreat.text = PlayerPrefs.GetFloat("TrickOrTreatScore", 0).ToString();
        
        currency.text = PlayerPrefs.GetFloat("currency", 0).ToString();

        PlayerPrefs.SetInt("skin", 1);
    }

}
