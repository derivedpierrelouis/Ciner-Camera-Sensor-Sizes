using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	public Transform cam;
	public float magnitude = 0.1f;
	public float speed = 0.1f;
	Vector3 pos;
	float timer;
	
	void Update()
	{
		Shake();
	}
    public void Shake()
    {        
        float x = Random.Range(-1f, 1f) * magnitude;
        float y = Random.Range(-1f, 1f) * magnitude;

        pos = new Vector3(cam.localPosition.x + x, cam.localPosition.y + y, cam.localPosition.z);
		cam.position = Vector3.Lerp(cam.position, pos, speed);
    }
   
}