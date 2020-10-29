using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
	public Transform cam;
	public Transform point;
	public float speedRotate = 5.0f;
	private Vector3 vectorType;
	public bool isRot;
    // Start is called before the first frame update
    void Start()
    {
	  cam.parent = point;
	  vectorType = Vector3.left;
	}

    // Update is called once per frame
    void Update()
    {
	  if(isRot)
	  {
	  point.Rotate(vectorType,speedRotate);
	  }
    }
	
	public void rotUp()
	{
		vectorType = Vector3.up;
	}
	public void rotDown()
	{
		vectorType = Vector3.down;
	}
	public void rotRight()
	{
		vectorType = Vector3.right;
	}
	public void rotLeft()
	{
		vectorType = Vector3.left;
	}
	public void rotForward()
	{
		vectorType = Vector3.forward;
	}
	public void rotBack()
	{
		vectorType = Vector3.back;
	}
	public void startRotate()
	{
		isRot = true;
	}
	public void stopRotate()
	{
		isRot = false;
	}
}
