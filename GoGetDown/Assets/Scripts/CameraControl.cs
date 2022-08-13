using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform target;

    public float offset;

    private void LateUpdate()
    {

        Vector3 newPos = new Vector3(0f, target.position.y-offset, -10f);
        transform.position = newPos;
    }
 
}
