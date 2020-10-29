using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class PanTiltCamera : MonoBehaviour
{
	public Transform cam;
	public Quaternion position;	
	public float speed = 0.1f;	
	public bool isMove;	
	
    void Update()
    {
		if(isMove)
		{
        cam.localRotation = Quaternion.Lerp(cam.localRotation,position,speed);
		}
    }

    public void startMove()
    {
        isMove = true;
    }
	
	public void stopMove()
	{
		isMove = false;
	}
	public void reset()
	{
		cam.localRotation = new Quaternion(0,0,0,0);
		position = new Quaternion(0,0,0,0);
	}
}