using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // reference the player gameobject's position;
    public GameObject player;

    // Distance between Camera and player
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update camera after player moved
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
