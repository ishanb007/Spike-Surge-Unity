using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutSceneManage : MonoBehaviour
{

    public GameObject[] players;
    public GameObject startBut;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Steps());
    }

    IEnumerator Steps()
    {
        Debug.Log("Play");
        yield return new WaitForSeconds(1f);
        players[0].GetComponent<PlayerControl>().OnMouseDown();
        yield return new WaitForSeconds(1.5f);
        players[1].GetComponent<PlayerControl>().OnMouseDown();
        yield return new WaitForSeconds(1.3f);
        players[0].GetComponent<PlayerControl>().OnMouseDown();
        yield return new WaitForSeconds(1f);
        startBut.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        foreach (GameObject item in players)
        {
            item.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }

    public void StartGame(){
        Debug.Log("click");
        SceneManager.LoadScene("MainMenu");
    }
}
