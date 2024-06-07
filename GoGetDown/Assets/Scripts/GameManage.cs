using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManage : MonoBehaviour {


    public GameObject[] players;
    public GameObject[] others;
    public GameObject[] explosions;
    public GameObject panel,currBox,score;

    public GameObject adsManager;
    public GameObject rev1,rev2,revAd,home,relo,skip,tex;
    public  TextMeshProUGUI currency;

    public float speed = -1.5f;
    public float superSpeed = 5000f;

    public float offset;

    public AudioSource hit;
    private AudioSource bgm;

    public void GameOver()
    {
        StartCoroutine(GameOver1());
    }

    void Start(){
        if(PlayerPrefs.GetInt("aud")==0){
            bgm = GetComponent<AudioSource>();
            bgm.enabled = false;
            players[0].GetComponent<AudioSource>().enabled=false;
        }
        StartCoroutine(TextDisap());
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Reload()
    {
        Scene restart = SceneManager.GetActiveScene();
        SceneManager.LoadScene (restart.name);
    }
    public void Skip(){
        rev1.SetActive(false);
        rev2.SetActive(false);
        revAd.SetActive(false);
        skip.SetActive(false);
        home.SetActive(true);
        relo.SetActive(true);
    }

    IEnumerator GameOver1()
    {
        hit.Play();
        foreach (GameObject particle in explosions)
        {
            particle.SetActive(true);
        }
        yield return new WaitForSeconds(0.1f);
        foreach (GameObject rbs in players)
        {
            rbs.SetActive(false);
        }
        foreach (GameObject other in others)
        {
            other.SetActive(false);
        }
        score.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        currency.SetText(PlayerPrefs.GetFloat("currency").ToString());
        currBox.SetActive(true);
        adsManager.GetComponent<GoogleAdsInGame>().ShowAd();
        panel.SetActive(true);
    }
    public void ReviveCost(){
        if(PlayerPrefs.GetFloat("currency")<200)return;
        PlayerPrefs.SetFloat("currency", PlayerPrefs.GetFloat("currency") - 200);
        currency.SetText(PlayerPrefs.GetFloat("currency").ToString());
        Revive();
    }
    public void Revive(){
        panel.SetActive(false);
        currBox.SetActive(false);
        score.SetActive(true);
        foreach (GameObject particle in explosions)
        {
            particle.SetActive(false);
        }
        foreach (GameObject other in others)
        {
            other.SetActive(true);
        }
        foreach (GameObject rbs in players)
        {
            rbs.SetActive(true);
            rbs.transform.position = rbs.transform.position + new Vector3(0,offset,0);
            rbs.GetComponent<Rigidbody2D>().AddForce(transform.up * speed * Time.fixedDeltaTime * superSpeed, ForceMode2D.Force);
        }
    }
    IEnumerator TextDisap()
    {
        yield return new WaitForSeconds(2f);
        tex.SetActive(false);
        
    }

}
