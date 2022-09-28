using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _player;
    //public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(_player.transform.position.x + offset.x, _player.transform.position.y + offset.y, offset.z);
    }
}