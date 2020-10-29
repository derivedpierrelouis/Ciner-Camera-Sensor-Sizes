using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		FullFrame = 0,
		ApsH = 1,
		ApsC = 2,
		ApsCCanon = 3,
		FoveonX3 = 4,
		FourThirds = 5,
		One = 6,
		TwoOverThree = 7,
		OnePointSeven = 8,
		TwoPointFive = 9,
	}
	
	
	 void OnEnable()
    {
        SetValues();
    }

    void OnValidate() {
        if (!enabled)
            return;

        SetValues();
    }
	public sensorName sensorType;
	public int index;

        static readonly Vector2[] sensorList =
        {
            new Vector2(36f, 24f),
            new Vector2(28.7f, 19f),
            new Vector2(23.6f, 15.7f),
            new Vector2(22.2f, 14.8f),
            new Vector2(20.7f, 13.8f),
            new Vector2(17.3f, 13f),
            new Vector2(13.2f, 8.8f),
            new Vector2(8.6f, 6.6f),
            new Vector2(7.6f, 5.7f),
            new Vector2(5.76f, 4.29f)
        };

    // Update is called once per frame
    void SetValues()
    {
		cam = GetComponent<Camera>();
		cam.usePhysicalProperties = true;
        index = (int)sensorType;
		cam.sensorSize = sensorList[index];
    }
}