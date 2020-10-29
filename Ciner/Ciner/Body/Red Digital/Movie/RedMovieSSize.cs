using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RedMovieSSize : MonoBehaviour
{
	public Camera cam;
	public enum sensorName
	{
		DSMC2BrainMonstro8KVV = 0,
		DSMC2BrainHelium8KS35 = 1,
		DSMC2BrainGemini5KS35 = 2,
		DSMC2BrainDragonX6KS35 = 3,
		DSMC2MonochromeBrainMonstro8KVV = 4,
		DSMC2MonochromeBrainHelium8KS35 = 5,
		REDRangerMonstro = 5,
		REDRangerHelium = 5,
		REDRangerGemini = 5,

	}
        static readonly string[] nameCamera =
        {
            "DSMC2 Brain Monstro 8K VV",
            "DSMC2 Brain Helium 8K S35",
            "DSMC2 Brain Gemini 5K S35",
            "DSMC2 Brain Dragon X 6K S35",
            "DSMC2 Monochrome Brain Monstro 8K VV",
            "DSMC2 Monochrome Brain Helium 8K S35",
            "RED Ranger Monstro",
            "RED Ranger Helium",
            "RED Ranger Gemini",
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
            new Vector2(40.96f, 21.60f),
			new Vector2(29.90f, 15.77f),
            new Vector2(30.72f, 18.0f),
            new Vector2(25.6f,  13.5f),
			new Vector2(40.96f, 21.60f),
			new Vector2(29.90f, 15.77f),
			new Vector2(40.96f, 21.60f),
			new Vector2(29.90f, 15.77f),
			new Vector2(30.72f, 18.0f),
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