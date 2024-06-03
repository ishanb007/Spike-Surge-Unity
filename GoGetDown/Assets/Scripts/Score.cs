using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

    public GameObject playerLine;

    // public int noOfPlayers=3;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI panelText;
    public TextMeshProUGUI highscorePanelText;
    public string playerPrefScore;

    public float SCORE;
    public float oldSCORE= 200f;

    public GameObject[] generators;


 
    void Update ()
    {
        SCORE = playerLine.GetComponent<LineCollide>().score;
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
    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("currency", SCORE + PlayerPrefs.GetFloat("currency"));
    }
}
