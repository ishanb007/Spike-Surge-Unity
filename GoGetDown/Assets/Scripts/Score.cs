using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameObject player;

    // public int noOfPlayers=3;

    public Text scoreText;
    public Text panelText;
    public Text highscorePanelText;
    public string playerPrefScore;

    public float SCORE;
    public float oldSCORE= 200f;

    public GameObject[] generators;
 
    void Update ()
    {
        SCORE = player.GetComponent<PlayerControl>().score;
        // generators = new GameObject[noOfPlayers];
        scoreText.text = SCORE.ToString("0");
        panelText.text = SCORE.ToString("0");
        if (SCORE > PlayerPrefs.GetFloat(playerPrefScore))
        {
            PlayerPrefs.SetFloat(playerPrefScore, SCORE);

        }
        highscorePanelText.text = PlayerPrefs.GetFloat(playerPrefScore).ToString();
        if (SCORE >= oldSCORE +25)
        {
            foreach (GameObject generator in generators)
            {
                generator.GetComponent<DestroyInstatntiation>().SPAWN();    
            }
        
            oldSCORE = SCORE;
            Debug.Log(oldSCORE);
        }
	}
    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("currency", SCORE + PlayerPrefs.GetFloat("currency"));

    }
}
