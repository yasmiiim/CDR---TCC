using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;

    private void FixedUpdate()
    {
        transform.position = player.position + new Vector3(0, 0, -10);
    }

}
