using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInstatntiation : MonoBehaviour {

    public GameObject playerprefab;

    public int numberOfPlatforms = 250;
    public int numberOfPlatforms1 = 25;
    public float levelWidth = 0.5f;
    public float levelWidth1 =2.2f;

    public float minY = 6f;
    public float maxY = 10f;

    Vector3 spawnPosition = new Vector3();
    float spawnX;

    public float initialOffset=0;


    void Start()
    {
        spawnPosition.y -=initialOffset;
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnX = Random.value;
            if (spawnX >=0.5)
            {
                spawnPosition.x = levelWidth;
            }
            else if (spawnX < 0.5)
            {
                spawnPosition.x = levelWidth1;
            }
            spawnPosition.y -= Random.Range(minY, maxY);
           
            Instantiate(playerprefab, spawnPosition, Quaternion.identity);
           
        }
    }

   public void SPAWN()
    {

      for (int i = 0; i < numberOfPlatforms1; i++)
        {

            spawnX = Random.value;
            if (spawnX >= 0.5)
            {
                spawnPosition.x = levelWidth;
            }
            else if (spawnX < 0.5)
            {
                spawnPosition.x = levelWidth1;
            }
            spawnPosition.y -= Random.Range(minY, maxY);

            Instantiate(playerprefab, spawnPosition, Quaternion.identity);
            Debug.Log(i);

        }
   }
}
