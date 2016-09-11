using UnityEngine;
using System.Collections;

public class StartImage : MonoBehaviour {

	public GameObject image;
	public GameObject text;
	SplineInterpolator cart;
	public float timeStopped = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("asdf");
		Debug.Log (other.ToString ());

		if(other.GetComponent(typeof(SplineInterpolator))) {
			Debug.Log ("here");
			SplineInterpolator temp = (SplineInterpolator)other.GetComponent (typeof(SplineInterpolator));
			cart = temp;
			temp.stopState ();
			Debug.Log ("done?");
			Invoke ("continueRolling", timeStopped);
			
		}
}
	void continueRolling(){
		Debug.Log ("continuing on the roller coaster");
		cart.continueState ();
	}
}
