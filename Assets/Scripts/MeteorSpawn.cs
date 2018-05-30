using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour {

    private float minTime = 1f;
    private float maxTime = 2f;
    private float elopsedTime = 0f;
    private float counter = 0f;
    private Vector3 spawnPos;
    public GameObject meteorPrefab;
	
	void Start () {
        Spawn();
	}

    void Spawn()
    {
        spawnPos = transform.position + new Vector3(Random.Range(-6, 6), 0, 0);
        Instantiate(meteorPrefab, spawnPos, Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
    }
	
    void Update()
    {
        elopsedTime += Time.deltaTime;
        counter += Time.deltaTime;

        if (elopsedTime < 30)
        {
            if (counter > 3)
            {
                Invoke("Spawn", Random.Range(minTime, maxTime));

                counter = 0;
            }
        }
        else if(elopsedTime >=30 && elopsedTime < 60)
        {
            if(counter > 2.5)
            {
                Invoke("Spawn", Random.Range(minTime, maxTime));

                counter = 0;
            }
        }
        else if(elopsedTime >= 60 && elopsedTime < 100)
        {
            if(counter > 2)
            {
                Invoke("Spawn", Random.Range(minTime, maxTime));

                counter = 0;
            }
        }
        else
        {
            if(counter > 1.5)
            {
                Invoke("Spawn", Random.Range(minTime, maxTime));
          
                counter = 0;
            }
        }

    }
	
}
