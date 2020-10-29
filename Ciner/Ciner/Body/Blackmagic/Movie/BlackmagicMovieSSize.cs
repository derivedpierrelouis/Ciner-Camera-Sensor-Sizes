using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BlackmagicMovieSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		BlackmagicURSAMiniPro12K = 0,
		BlackmagicURSAMiniPro46KG2 = 1,
		BlackmagicURSABroadcast = 2,
		BlackmagicStudioCamera = 3,
		BlackmagicMicroStudioCamera4K = 4,
		BlackmagicMicroCinemaCamera = 5,
		BlackmagicPocketCinemaCamera6K = 6,
		BlackmagicDesignURSAMini4K = 7,
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
            new Vector2(27.03f, 14.25f),
			new Vector2(25.34f, 14.25f),
            new Vector2(13.056f, 7.344f),
            new Vector2(12.48f,  7.02f),
			new Vector2(13.056f, 7.344f),
			new Vector2(12.48f,  7.02f),
			new Vector2(23.10f,  12.99f),
			new Vector2(21.12f,  11.88f),
        };
        static readonly string[] nameCamera =
        {
            "Blackmagic URSA Mini Pro 12K",
            "Blackmagic URSA Mini Pro 4.6K G2",
            "Blackmagic URSA Broadcast",
            "Blackmagic Studio Camera",
            "Blackmagic Micro Studio Camera 4K",
            "Blackmagic Micro Cinema Camera",
            "Blackmagic Pocket Cinema Camera 6K",
            "Blackmagic Design URSA Mini 4K",
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