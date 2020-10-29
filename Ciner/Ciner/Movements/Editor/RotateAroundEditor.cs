using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RotateAround))]
public class RotateAroundEditor : Editor
{
	public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        RotateAround rotateScript = (RotateAround)target;
        if(GUILayout.Button("Rotate Up"))
        {
            rotateScript.rotUp();
        } 
		if(GUILayout.Button("Rotate Down"))
        {
            rotateScript.rotDown();
        }
		if(GUILayout.Button("Rotate Right"))
        {
            rotateScript.rotRight();
        }
		if(GUILayout.Button("Rotate Left"))
        {
            rotateScript.rotLeft();
        }
		if(GUILayout.Button("Rotate Forward"))
        {
            rotateScript.rotForward();
        }
		if(GUILayout.Button("Rotate Backward"))
        {
            rotateScript.rotBack();
        }
		if(GUILayout.Button("Start"))
        {
            rotateScript.startRotate();
        }
		if(GUILayout.Button("Stop"))
        {
            rotateScript.stopRotate();
        }
    }

}
