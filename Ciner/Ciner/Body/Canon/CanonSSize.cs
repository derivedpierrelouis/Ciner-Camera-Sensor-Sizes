using UnityEngine;
using System.Collections;
using System;

[ExecuteInEditMode]
public class CanonSSize : MonoBehaviour
{
	public Camera cam;
        static readonly string[] nameCamera =
        {
            "Canon EOS 1DX Mark III",
            "Canon EOS RP",
            "Canon EOS R",
            "Canon EOS 6D Mark II",
            "Canon EOS 5D Mark IV",
            "Canon EOS 1DX Mark II",
            "Canon EOS 5D S",
            "Canon EOS 5D SR",
            "Canon EOS 6D",
            "Canon EOS 1D X",
            "Canon EOS 5D MarkII",
            "Canon EOS 1D S Mark III",
            "Canon EOS 2000D",
            "Canon EOS 4000D",
            "Canon EOS M100",
            "Canon EOS 200D",
            "Canon EOS 77D",
            "Canon EOS M6",
            "Canon EOS M5",
            "Canon EOS 1300D",
            "Canon EOS 80D",
            "Canon EOS M10",
            "Canon EOS 750D",
            "Canon EOS 760D",
            "Canon EOS M3",
            "Canon EOS 7D Mark II",
            "Canon EOS 1200D",
            "Canon EOS M2",
            "Canon EOS 70D",
            "Canon EOS 700D",
            "Canon EOS 100D",
            "Canon EOS M",
            "Canon EOS 650D",
            "Canon EOS 1100D",
            "Canon EOS 600D",
            "Canon EOS 60D",
            "Canon EOS 550D",
            "Canon EOS 1D Mark IV",
            "Canon EOS R5",
            "Canon EOS R6",
            "Canon EOS Ra",
        };
	public enum sensorName
	{
		CanonEos1DXMarkIII = 0,
		CanonEosRP = 1,
		CanonEosR = 2,
		CanonEos6DMarkII = 3,
		CanonEos5DMarkIV = 4,
		CanonEos1DXMarkII = 5,
		CanonEos5DS = 6,
		CanonEos5DSR = 7,
		CanonEos6D = 8,
		CanonEos5DMarkIII = 9,
		CanonEos1DX = 10,
		CanonEos5DMarkII = 11,
		CanonEos1DSMarkIII = 12,
		CanonEos2000D = 13,
		CanonEos4000D = 14,
		CanonEosM100 = 15,
		CanonEos200D = 16,
		CanonEos77D = 17,
		CanonEosM6 = 18,
		CanonEosM5 = 19,
		CanonEos1300D = 20,
		CanonEos80D = 21,
		CanonEosM10 = 22,
		CanonEos750D = 23,
		CanonEos760D = 24,
		CanonEosM3 = 25,
		CanonEos7DMarkII = 26,
		CanonEos1200D = 27,
		CanonEosM2 = 28,
		CanonEos70D = 29,
		CanonEos700D = 30,
		CanonEos100D = 31,
		CanonEosM = 32,
		CanonEos650D = 33,
		CanonEos1100D = 34,
		CanonEos600D = 35,
		CanonEos60D = 36,
		CanonEos550D = 37,
		CanonEos1DMarkIV = 38,
		CanonEosR5 = 39,
		CanonEosR6 = 40,
		EosRa = 41,
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
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(22.2f, 14.8f),
			new Vector2(28.7f, 19f),
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
