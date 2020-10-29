using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ArriMovieSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		AlexaLF = 0,
		ALEXAMiniLF = 1,
		ALEXASxtW = 2,
		ALEXAMini = 3,
		AMIRA = 4,
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
	int index;


		// Sensor sizes
        static readonly Vector2[] sensorList =
        {
            new Vector2(36.7f, 25.54f),
			new Vector2(36.7f, 25.54f),
            new Vector2(28.25f, 18.17f),
			new Vector2(28.25f, 18.17f),
			new Vector2(28.17f, 18.13f),
        };
		
		// Names of cameras
        static readonly string[] nameCamera =
        {
            "ALEXA LF",
            "ALEXA Mini LF",
            "ALEXA SXT W",
            "ALEXA Mini",
            "ALEXA AMIRA",
        };

    // Set values on runtime
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