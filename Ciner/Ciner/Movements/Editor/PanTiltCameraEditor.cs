using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PanTiltCamera))]
public class PanTiltCameraEditor : Editor
{
	public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        PanTiltCamera panTilt = (PanTiltCamera)target;
        if(GUILayout.Button("Start"))
        {
            panTilt.startMove();
        } 
		if(GUILayout.Button("Stop"))
        {
            panTilt.stopMove();
        }
		if(GUILayout.Button("Reset"))
        {
            panTilt.reset();
            panTilt.stopMove();
        }
    }

}
