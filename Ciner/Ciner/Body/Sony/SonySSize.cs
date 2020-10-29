using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SonySSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		Alpha7C = 0,
		α7SIII = 1,
		a9II = 2,
		SonyA7rIV = 3,
		SonyA7III = 4,
		SonyA7RIII = 5,
		SonyA9 = 6,
		SonySltAlpha99II = 7,
		SonyCyberShotDscRX1RII = 8,
		SonyA7SII = 9,
		SonyA7RII = 10,
		SonyA7II = 11,
		SonyA7S = 12,
		SonyA7R = 13,
		SonyCyberShotDscRX1R = 14,
		SonyCyberShotDscRX1 = 15,
		SonySltAlpha99 = 16,
		SonyAlpha850 = 17,
		SonyA6600 = 18,
		SonyA6400 = 19,
		SonyA6500 = 20,
		SonyA6300 = 21,
		SonyA5100 = 22,
		SonyAlpha500 = 23,
		SonySltAlpha77II = 24,
		SonyA6000 = 25,
		SonyA5000 = 26,
		SonyNEX5T = 27,
		SonyA3000 = 28,
		SonyNEX3N = 29,
		SonySltAlpha58 = 30,
		SonyNEX6 = 31,
		SonyNEX5R = 32,
		SonyNEXF3 = 33,
		SonySltAlpha37 = 34,
		SonySltAlpha57 = 35,
		SonySltAlpha77 = 36,
		SonySltAlpha65 = 37,
		SonyNEX7 = 38,
		SonyNEX5N = 39,
		SonyNEXC3 = 40,
		SonySltAlpha35 = 41,
		SonySltAlpha33 = 42,
		SonySltAlpha55 = 43,
		SonyAlpha580 = 44,
		SonyAlpha560 = 45,
		SonyAlpha390 = 46,
		SonyAlpha290 = 47,
		SonyNEX3 = 48,
		SonyNEX5 = 49,
		SonyAlpha450 = 50,
	}
        static readonly string[] nameCamera =
        {
            "Sony Alpha 7C",
            "Sony α7S III",
            "Sony a9 II",
            "Sony A7r IV",
            "Sony A7 III",
            "Sony A7R III",
            "Sony A9",
            "Sony SLT Alpha 99 II",
            "Sony Cyber Shot DSC RX1R II",
            "Sony A7S II",
            "Sony A7R II",
            "Sony A7 II",
            "Sony A7S",
            "Sony A7R",
            "Sony Cyber Shot DSC RX1 R",
            "Sony Cyber Shot DSC RX1",
            "Sony SLT Alpha 99",
            "Sony Alpha 850",
            "Sony A6600",
            "Sony A6400",
            "Sony A6500",
            "Sony A6300",
            "Sony A5100",
            "Sony Alpha 500",
            "Sony SLT Alpha 77 II",
            "Sony A6000",
            "Sony A5000",
            "Sony NEX 5T",
            "Sony A3000",
            "Sony NEX 3N",
            "Sony SLT Alpha 58",
            "Sony NEX 6",
            "Sony NEX 5R",
            "Sony NEX F3",
            "Sony SLT Alpha 37",
            "Sony SLT Alpha 77",
            "Sony SLT Alpha 65",
            "Sony NEX 7",
            "Sony NEX 5N",
            "Sony NEX C3",
            "Sony SLT Alpha 35",
            "Sony SLT Alpha 33",
            "Sony SLT Alpha 55",
            "Sony Alpha 580",
            "Sony Alpha 560",
            "Sony Alpha 390",
            "Sony Alpha 290",
            "Sony NEX 3",
            "Sony NEX 5",
            "Sony Alpha 450",
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
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
            new Vector2(36f, 24f),
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