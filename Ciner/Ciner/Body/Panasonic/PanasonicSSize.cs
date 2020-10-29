using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PanasonicSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		LumixS1H = 0,
		PanasonicLumixS5 = 1,
		LumixS1R = 2,
		LumixS1 = 3,
	}
        static readonly string[] nameCamera =
        {
            "Lumix S1H",
            "Panasonic Lumix S5",
            "Lumix S1R",
            "Lumix S1",
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
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
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