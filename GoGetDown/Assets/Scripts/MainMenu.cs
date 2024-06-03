using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class MainMenu : MonoBehaviour {

    public GameObject firstScreen;
    public GameObject secondScreen;
    public GameObject backButton;
    public GameObject aud1,aud2;

    private AudioSource bgm;
    
    public TextMeshProUGUI scoreEasy1;
    public  TextMeshProUGUI scoreHard1;
    public  TextMeshProUGUI gemCollector1;
    public  TextMeshProUGUI trickOrTreat1;
    public  TextMeshProUGUI quadFraud1;

    public TMP_Text currency1;

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
        backButton.SetActive(true);
    }
    public void BackToMain()
    {
        secondScreen.SetActive(false);
        backButton.SetActive(false);
        firstScreen.SetActive(true);
    }


    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/incessant_games");
    }
    public void PrivPolicy()
    {
        Application.OpenURL("https://docs.google.com/document/d/1BJ7LyG-bopyW0xiMCE72mkR0NRN2nrYXkPrXKan6CAc/edit?pli=1");
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
        aud1.SetActive(!aud1.activeSelf);
        aud2.SetActive(!aud2.activeSelf);
        if(PlayerPrefs.GetInt("aud")==1){
            PlayerPrefs.SetInt("aud",0);
        }
        else{PlayerPrefs.SetInt("aud",1);}
    }



    public void Easy()
    {
        SceneManager.LoadScene("DoubleTrouble");
    }
    public void Hard()
    {
        SceneManager.LoadScene("TripleSurge");
    }
    public void QuadFraud()
    {
        SceneManager.LoadScene("QuadFraud");
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
        scoreEasy1.SetText(PlayerPrefs.GetFloat("DoubleTroubleScore", 0).ToString());
        scoreHard1.SetText(PlayerPrefs.GetFloat("TripleSurgeScore", 0).ToString());
        gemCollector1.SetText(PlayerPrefs.GetFloat("GemCollectorScore", 0).ToString());
        trickOrTreat1.SetText(PlayerPrefs.GetFloat("TrickOrTreatScore", 0).ToString());
        quadFraud1.SetText(PlayerPrefs.GetFloat("QuadFraudScore", 0).ToString());
        
        currency1.SetText(PlayerPrefs.GetFloat("currency", 0).ToString());

        
        
        if (PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {
            Debug.Log("First Time Opening");

            //Set first time opening to false
            PlayerPrefs.SetInt("FIRSTTIMEOPENING", 0);

            PlayerPrefs.SetInt("skin", 1);
            PlayerPrefs.SetInt("aud",1);
        }
        else
        {
            Debug.Log("NOT First Time Opening");
            if(PlayerPrefs.GetInt("aud")==0){
                bgm = GetComponent<AudioSource>();
                bgm.enabled = !bgm.enabled;
                aud1.SetActive(!aud1.activeSelf);
                aud2.SetActive(!aud2.activeSelf);
            }
        }

        

        
    }

}
