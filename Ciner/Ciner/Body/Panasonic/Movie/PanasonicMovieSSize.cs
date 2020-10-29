using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PanasonicMovieSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		VariCamLT = 0,
		VariCam35 = 1,
		VariCamPURE = 2,
		AuEVA1 = 3,
	}
        static readonly string[] nameCamera =
        {
            "Panasonic VariCam LT",
            "Panasonic VariCam 35",
            "Panasonic VariCam PURE",
            "Panasonic AU EVA1 5.6k",
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
            new Vector2(24.89f, 18.66f),
            new Vector2(24.89f, 18.66f),
            new Vector2(24.89f, 18.66f),
            new Vector2(24.89f, 18.66f),
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