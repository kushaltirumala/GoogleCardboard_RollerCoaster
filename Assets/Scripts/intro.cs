using UnityEngine;
using System.Collections;

public class intro : MonoBehaviour {
	
	public GUIStyle custom;
	public GUIStyle custom1;
	
	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	
	void OnGUI () {
		//GUILayout.BeginArea( new Rect( 0, 0, Screen.height*.5f, Screen.width*.5f) );
		
		GUI.Label(new Rect(Screen.width*.5f,Screen.height*.15f, 0, 0),"Rollercoaster Simulator",custom);
		GUI.Label(new Rect(Screen.width*.5f,Screen.height*.22f, 0, 0),"Move your phone around and select a rollercoaster to ride it.",custom1);
		
	}
}



