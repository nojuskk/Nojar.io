using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerColor : MonoBehaviour {

    public Material yellow;
    public Material red;
    public Material blue;
    public Material purple;
    public Material green;

    // Use this for initialization
    void Start () {
       
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Blue()
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material = blue;
        }
    }

    public void Yellow()
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material = yellow;
        }

    }
    public void Purple()
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material = purple;
        }
    }
    public void Green()
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material = green;
        }
    }
    public void Red()
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material = red;
        }
    }
}
