using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollide : MonoBehaviour
{
    
    public GameObject GameManager;

    private int count=0;
    public int reqCount=2;
    public int score = 0;

    public GameObject[] hearts;
    public int i=2;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == ("Collect"))
        {
            count+=1;
            if(i>=0){
            hearts[i].SetActive(false);
            i--;}
            OnHit();
        } 
        else if (col.tag == ("Obstacles"))
        {
            score +=1;
        }
    }
    public void OnHit(){
        if (count > reqCount){
            count = 0;
            GameManager.GetComponent<GameManage>().GameOver();
        }
    }
}
