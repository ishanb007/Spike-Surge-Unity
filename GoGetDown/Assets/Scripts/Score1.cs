using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour {

    public GameObject player;

    public Text scoreText;
    public Text panelText;
    public Text highscorePanelText;

    public float SCORE;
    public float oldSCORE= 200f;

    public GameObject generator;
    public GameObject generator1;
    public GameObject generator2;

    void Update ()
    {
        SCORE = player.GetComponent<PlayerControl>().score;
        scoreText.text = SCORE.ToString("0");
        panelText.text = SCORE.ToString("0");
        if (SCORE > PlayerPrefs.GetFloat("HardScore"))
        {
            PlayerPrefs.SetFloat("HardScore", SCORE);

        }
        highscorePanelText.text = PlayerPrefs.GetFloat("HardScore").ToString();
        if (SCORE >= oldSCORE + 25)
        {
            generator.GetComponent<DestroyInstatntiation>().SPAWN();
            generator1.GetComponent<DestroyInstatntiation>().SPAWN();
            generator2.GetComponent<DestroyInstatntiation>().SPAWN();
            oldSCORE = SCORE;
            Debug.Log(oldSCORE);
        }
	}
    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("currency", SCORE + PlayerPrefs.GetFloat("currency"));

    }
}
