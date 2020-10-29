using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SonyMovieSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		PxwFX9 = 0,
		PxwFS7M2 = 1,
		PxwFS7 = 2,
		PxwFS5M2 = 3,
		PxwZ280 = 4,
		PxwZ190 = 5,
		PxwZ150 = 6,
		PxwZ90 = 7,
		HxrNX200 = 8,
		HxrNX100 = 9,
		HxrNX80 = 10,
		HxrMC88 = 11,
	}
        static readonly string[] nameCamera =
        {
            "Sony PXW FX9",
            "Sony PXW FS7 M2",
            "Sony PXW FS7",
            "Sony PXW FS5 M2",
            "Sony PXW Z280",
            "Sony PXW Z190",
            "Sony PXW Z150",
            "Sony PXW Z90",
            "Sony HXR NX200",
            "Sony HXR NX100",
            "Sony HXR NX80",
            "Sony HXR MC88",
        };
	
	
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
	int index;

        static readonly Vector2[] sensorList =
        {
            new Vector2(36f, 24f),
            new Vector2(24.6f, 13.8f),
            new Vector2(24.6f, 13.8f),
            new Vector2(24.6f, 13.8f),
            new Vector2(6.17f, 4.55f),
            new Vector2(4.8f, 3.6f),
            new Vector2(13.2f, 8.8f),
            new Vector2(13.2f, 8.8f),
            new Vector2(13.2f, 8.8f),
            new Vector2(13.2f, 8.8f),
            new Vector2(13.2f, 8.8f),
            new Vector2(13.2f, 8.8f),
        };

    // Update is called once per frame
    void SetValues()
    {
		cam = GetComponent<Camera>();
		cam.usePhysicalProperties = true;
        index = (int)sensorType;
		cam.sensorSize = sensorList[index];
    	gameObject.name = nameCamera[index] + " " + cam.focalLength + "mm";
	}
    
	
	void Update()
	{
		gameObject.name = nameCamera[index] + " " + cam.focalLength + "mm";
	}
}