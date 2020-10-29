using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CanonMovieSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		EosC70 = 0,
		EosC700 = 1,
		EosC300MarkIII = 2,
		EosC700FFPL = 3,
		EosC500MarkII = 4,
		EosC700PL = 5,
		EosC700GSPL = 6,
		EosC300MarkII = 7,
		EosC300MarkIIPL = 8,
		EosC200 = 9,
		EosC200B = 10,
		EosC100MarkII = 11,
	}
        static readonly string[] nameCamera =
        {
            "Canon EOS C70",
            "Canon EOS C700",
            "Canon EOS C300 Mark III",
            "Canon EOS C700 FFPL",
            "Canon EOS C500 Mark II",
            "Canon EOS C700 PL",
            "Canon EOS C700 GSPL",
            "Canon EOS C300 Mark II",
            "Canon EOS C300 Mark II PL",
            "Canon EOS C200",
            "Canon EOS C200B",
            "Canon EOS C100 Mark II",
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
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
            new Vector2(26.2f, 13.8f),
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