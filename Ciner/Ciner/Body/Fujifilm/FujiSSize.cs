using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FujiSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		FujifilmGFX100 = 0,
		FujifilmGFX50S = 1,
		FujifilmGFX50R = 2,
		FujifilmXH1 = 3,
		FujifilmXPro3 = 4,
		FujifilmXPro2 = 5,
		FujifilmXT4 = 6,
		FujifilmXT3 = 7,
		FujifilmXT2 = 8,
		FujifilmXT30 = 9,
		FujifilmXT20 = 10,
		FujifilmXT200 = 11,
		FujifilmXT100= 12,
		FujifilmXE3= 13,
		FujifilmXA7= 14,
		FujifilmXA5= 15,
		FujifilmX100V= 16,
		FujifilmX100F= 17,
		FujifilmXF10= 18,
	}
        static readonly string[] nameCamera =
        {
            "Fujifilm GFX 100",
            "Fujifilm GFX 50S",
            "Fujifilm GFX 50R",
            "Fujifilm XH1",
            "Fujifilm X Pro3",
            "Fujifilm X Pro2",
            "Fujifilm XT4",
            "Fujifilm XT3",
            "Fujifilm XT2",
            "Fujifilm XT30",
            "Fujifilm XT20",
            "Fujifilm XT200",
            "Fujifilm XT100",
            "Fujifilm XE3",
            "Fujifilm XA7",
            "Fujifilm XA5",
            "Fujifilm X100V",
            "Fujifilm X100F",
            "Fujifilm XF10"
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
            new Vector2(43.8f, 32.9f),
            new Vector2(43.8f, 32.9f),
            new Vector2(43.8f, 32.9f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
            new Vector2(23.6f, 15.7f),
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