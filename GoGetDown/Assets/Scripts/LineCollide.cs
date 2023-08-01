using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollide : MonoBehaviour
{
    
    public GameObject GameManager;

    private int count=0;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == ("Obstacles"))
        {
            count+=1;
             OnHit();
        }
    }
    public void OnHit(){
        if (count > 2){
            GameManager.GetComponent<GameManage>().GameOver();
        }
    }
}
