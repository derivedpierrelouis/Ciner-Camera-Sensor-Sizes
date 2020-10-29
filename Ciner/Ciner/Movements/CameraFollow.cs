using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform cam;
	public Transform point;
	public Vector3 offset;
	public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
      offset = cam.position - point.position;
    }

    // Update is called once per frame
    void Update()
    {
	  Vector3 targetPosition = point.position + offset;
      cam.position += (targetPosition - cam.position) * speed;
    }
}
