using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class NikonSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		NikonD6 = 0,
		NikonD780 = 1,
		NikonD850 = 2,
		NikonD5 = 3,
		NikonD750 = 4,
		NikonD610 = 5,
		NikonDf = 6,
		NikonD810A = 7,
		NikonZ6 = 8,
		NikonZ7 = 9,
		NikonZ5 = 10,
		NikonD810 = 11,
		NikonD4s = 12,
		NikonD600 = 13,
		NikonD800 = 14,
		NikonD800E = 15,
		NikonD4 = 16,
		NikonD3s = 17,
		NikonD7500 = 18,
		NikonD5600 = 19,
		NikonD3400 = 20,
		NikonD500 = 21,
		NikonD7200 = 22,
		NikonD5500 = 23,
		NikonD3300 = 24,
		NikonD5300 = 25,
		NikonCoolpixA = 26,
		NikonD7100 = 27,
		NikonD5200 = 28,
		NikonD3200 = 29,
		NikonD5100 = 30,
		NikonD3100 = 31,
		NikonD7000 = 32,
		NikonD300s = 33,
		NikonD3000 = 34,
	}
	static readonly string[] nameCamera =
        {
            "Nikon D6",
            "Nikon D780",
            "Nikon D850",
            "Nikon D5",
            "Nikon D750",
            "Nikon D610",
            "Nikon Df",
            "Nikon D810A",
            "Nikon Z6",
            "Nikon Z7",
            "Nikon Z5",
            "Nikon D810",
            "Nikon D4s",
            "Nikon D600",
            "Nikon D800",
            "Nikon D800E",
            "Nikon D4",
            "Nikon D3s",
            "Nikon D7500",
            "Nikon D5600",
            "Nikon D3400",
            "Nikon D500",
            "Nikon D7200",
            "Nikon D5500",
            "Nikon D3300",
            "Nikon D5300",
            "Nikon CoolpixA",
            "Nikon D7100",
            "Nikon D5200",
            "Nikon D3200",
            "Nikon D5100",
            "Nikon D3100",
            "NikonD7000",
            "Nikon D300s",
            "Nikon D3000"
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
