using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 2f;
    public float decrease = 0.5f;
    SphereCollider myCollider;

    // Use this for initialization
    void Start () {
        myCollider = transform.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update() {
        Vector3 Mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Mouse.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, Mouse, speed * Time.deltaTime / (transform.localScale.x * 0.7f));

        if (Input.GetKeyDown(KeyCode.Space)){
            transform.localScale -= new Vector3(decrease, decrease, decrease);
            myCollider.radius += 0.1f;
        }
	}
}
