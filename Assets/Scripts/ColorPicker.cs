using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour {

    public List<Material> Color = new List<Material>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        GetComponent<Renderer>().material = Color[Random.Range(0, Color.Count)];
    }
}
