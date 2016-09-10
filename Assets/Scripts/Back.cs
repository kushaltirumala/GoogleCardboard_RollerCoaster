using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {
	public GameObject ad;

	public GUIStyle custom;
	public GUIStyle custom1;
	static public bool vr = false; 
	// Use this for initialization
	void Start () {
		
		
		
	}
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	// Update is called once per frame
	void Update(){
		Debug.Log (Application.loadedLevel );

		GameObject Object1 = GameObject.Find("Main Camera");
		if (vr == false)
		{
			GameObject.Find("Main Camera").GetComponent<gyro>().enabled = true ;
			//GameObject.Find("Dive_Camera").GetComponent<OpenDiveSensor>().enabled =false ;
			GameObject.Find("Camera_left").GetComponent<Camera>().enabled =false ;
		 GameObject.Find("Dive_Camera").transform.rotation=	GameObject.Find("Main Camera").transform.rotation;
			//GameObject.Find("Main Camera").camera.enabled =true ;
			GameObject.Find("Camera_left").tag = "zr";
			GameObject.Find("Camera_right").GetComponent<Camera>().enabled =false ;
		} else {
			
			//GameObject.Find("Main Camera").GetComponent<gyro>().enabled = false ;
			GameObject.Find("Dive_Camera").GetComponent<OpenDiveSensor>().enabled =true ;
			GameObject.Find("Main Camera").transform.rotation = GameObject.Find("Dive_Camera").transform.rotation;
			GameObject.Find("Camera_left").GetComponent<Camera>().enabled =true ;
			//GameObject.Find("Main Camera").camera.enabled =false ;
			GameObject.Find("Camera_left").tag = "vr";
			GameObject.Find("Camera_right").GetComponent<Camera>().enabled =true ;
			

		}



		if (GameObject.Find("back")!= this.gameObject){
			ad = GameObject.Find("back"); 
			Destroy(ad);
		}


	}
	void OnGUI () {
		//GUILayout.BeginArea( new Rect( 0, 0, Screen.height*.5f, Screen.width*.5f) );
		
	
		if (GUI.Button(new Rect(100,10, 100, 100),"Menu",custom1) || (Mathf.Abs (Input.gyro.gravity.x) > .7 && Application.loadedLevel != 0 && vr == true&& Time.timeSinceLevelLoad > 5) ){

			Application.LoadLevel("menu");

		}
		if (GUI.Button(new Rect(300,10, 300, 100),"3D VR: " + vr ,custom1)){
			
			if (vr == false)
			{
				vr = true;

			} else {

				vr = false;
			}



			
		}
		
	}
}

