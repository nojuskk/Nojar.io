using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour {

    public float SpawnTime = 1f;
    public GameObject Food;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Generate", 0, SpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Generate()
    {
        int width = Random.Range(0, Camera.main.pixelWidth + 500);
        int height = Random.Range(0, Camera.main.pixelHeight + 500);

        Vector3 Spawn = Camera.main.ScreenToWorldPoint(new Vector3(width, height, 0));

        Spawn.z = 0;

        Instantiate(Food, Spawn, Quaternion.identity);
    }
}
