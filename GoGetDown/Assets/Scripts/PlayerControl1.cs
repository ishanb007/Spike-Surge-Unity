using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl1 : MonoBehaviour {

    public GameObject[] skins;
    public GameObject basicSkin;

    public Rigidbody2D rb;
    public float XPos = 2f;
    public float XPos1 = 0f;

    public float speed = -1.5f;
    public float superSpeed = 5000f;

    public Vector3 position;

    public int score = 0;

    public void Awake()
    {
        int skin = PlayerPrefs.GetInt("skin");
        for (int i = 0; i < skins.Length; i++)
        {
            if(i+1 == skin)
            {
                skins[i].SetActive(true);
                basicSkin.SetActive(false);
            }

        }
    }

    private void Start()
    {
        rb.AddForce(transform.up * speed * Time.fixedDeltaTime * superSpeed, ForceMode2D.Force);
    }

    private void Update()
    {
        position = rb.position;
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.up * speed * Time.fixedDeltaTime *2f, ForceMode2D.Force);
    }

    public void OnMouseDownCLICK()
    {
      
        if (position.x == XPos)
        {
            position = rb.position;
            position.x = XPos1;
            rb.position = position;
        }
        else if (position.x == XPos1)
        {
            position = rb.position;
            position.x = XPos;
            rb.position = position;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == ("Obstacles"))
        {
            Destroy(col.gameObject);
            score += 1;
        }
    }
    private void OnMouseDown()
    {
        if (position.x == XPos)
        {
            position = rb.position;
            position.x = XPos1;
            rb.position = position;
        }
        else if (position.x == XPos1)
        {
            position = rb.position;
            position.x = XPos;
            rb.position = position;
        }
    }

    

}
