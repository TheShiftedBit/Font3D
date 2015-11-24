using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

[CustomEditor(typeof(Font3D))]
public class Font3DEditor : Editor
{
	public override void OnInspectorGUI()
	{
		//DrawDefaultInspector();
		EditorGUILayout.HelpBox("Rendering Fixed!", MessageType.None);
	}
}