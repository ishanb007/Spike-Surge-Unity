using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public Text panelText;
    public Text highscorePanelText;

    public float SCORE;
    public float oldSCORE= 200f;

    public GameObject generator;
    public GameObject generator1;

    public GameObject player;

    void Update ()
    {
        SCORE = player.GetComponent<PlayerControl>().score;

        scoreText.text = SCORE.ToString("0");
        panelText.text = SCORE.ToString("0");
        highscorePanelText.text = PlayerPrefs.GetFloat("EasyScore").ToString();
        if (SCORE > PlayerPrefs.GetFloat("EasyScore"))
        {
            PlayerPrefs.SetFloat("EasyScore", SCORE);
        }
        if (SCORE >= oldSCORE + 25)
        {
            generator.GetComponent<DestroyInstatntiation>().SPAWN();
            generator1.GetComponent<DestroyInstatntiation>().SPAWN();
            oldSCORE = SCORE;
            Debug.Log(oldSCORE);
        }
	}
    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("currency", SCORE+PlayerPrefs.GetFloat("currency"));

    }
}
