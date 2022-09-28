using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatFood : MonoBehaviour {

    public Text scoreText;
    private float score = 0f;
    public float Increase = 0.1f;
    public AudioClip eatSound;
    public AudioSource musicSource;

	// Use this for initialization
	void Start () {
        musicSource.clip = eatSound;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score : " + score;
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Food")
        {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);
            score++;
            musicSource.Play();
        }
    }
}
