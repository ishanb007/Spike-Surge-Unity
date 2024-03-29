using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetInstantiation : MonoBehaviour {

    public GameObject playerprefab;
    public GameObject playerprefabCollect;

    public int numberOfPlatforms = 250;
    public int numberOfPlatforms1 = 25;
    public float levelWidth = 0.5f;
    public float levelWidth1 =2.2f;

    public float minY = 6f;
    public float maxY = 10f;

    Vector3 spawnPosition = new Vector3();
    float spawnX;
    float selectObject;


    void Start()
    {
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
            
            selectObject = Random.value;
            if (selectObject>=0.5)
            {
                 Instantiate(playerprefab, spawnPosition, Quaternion.identity);
            }else{
                 Instantiate(playerprefabCollect, spawnPosition, Quaternion.identity);
            }
           
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

            selectObject = Random.value;
            if (selectObject>=0.5)
            {
                 Instantiate(playerprefab, spawnPosition, Quaternion.identity);
            }else{
                 Instantiate(playerprefabCollect, spawnPosition, Quaternion.identity);
            }
            Debug.Log(i);

        }
   }
}
