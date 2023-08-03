using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour {


    public GameObject[] players;
    public GameObject[] others;
    public GameObject[] explosions;
    public GameObject panel;

    public float speed = -1.5f;
    public float superSpeed = 5000f;

    public float offset;

    public AudioSource hit;

    public void GameOver()
    {
        StartCoroutine(GameOver1());
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
        yield return new WaitForSeconds(0.1f);
        panel.SetActive(true);
    }
    public void Revive(){
        panel.SetActive(false);
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

}
