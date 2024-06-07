using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score1 : MonoBehaviour {

    public GameObject player;
    public GameObject player2;
    public GameObject lineCollide;

    // public int noOfPlayers=3;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI panelText;
    public TextMeshProUGUI highscorePanelText;
    public string playerPrefScore;

    public float SCORE;
    public float SCORE1;
    public float SCORE2;
    public float SCORE3;
    public float oldSCORE= 200f;
    public float scoreSoFar=0;

    public GameObject[] generators;
 
    void Update ()
    {
        SCORE1 = player.GetComponent<PlayerControl1>().score;
        SCORE2 = player2.GetComponent<PlayerControl1>().score;
        SCORE3 = lineCollide.GetComponent<LineCollide>().score;
        SCORE=SCORE1+SCORE2+SCORE3;
        // generators = new GameObject[noOfPlayers];
        scoreText.SetText(SCORE.ToString("0"));
        panelText.SetText(SCORE.ToString("0"));
        if (SCORE > PlayerPrefs.GetFloat(playerPrefScore))
        {
            PlayerPrefs.SetFloat(playerPrefScore, SCORE);

        }
        highscorePanelText.SetText(PlayerPrefs.GetFloat(playerPrefScore).ToString());
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
    private void OnDisable() {
        Debug.Log("disabled");
        PlayerPrefs.SetFloat("currency", SCORE + PlayerPrefs.GetFloat("currency")-scoreSoFar);
        scoreSoFar=SCORE;
    }
    // private void OnDestroy()
    // {
    //     PlayerPrefs.SetFloat("currency", SCORE + PlayerPrefs.GetFloat("currency"));

    // }
}
