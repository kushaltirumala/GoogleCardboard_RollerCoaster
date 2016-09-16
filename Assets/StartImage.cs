using UnityEngine;
using System.Collections;

public class StartImage : MonoBehaviour {

	public GameObject thisObject;
	SplineInterpolator cart;
	public float timeStopped = 2f;
	public GameObject otherObject;
	public GameObject otherObject2;
	Animator animator;
	Animator animator2;
	// Use this for initialization
	void Start () {
		animator = otherObject.GetComponent<Animator> ();
		animator2 = otherObject2.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Debug.Log (other.ToString ());

		if(other.GetComponent(typeof(SplineInterpolator))) {
			SplineInterpolator temp = (SplineInterpolator)other.GetComponent (typeof(SplineInterpolator));
			cart = temp;
			temp.stopState ();
			if (thisObject.name ==("endTrigger")) {
				Debug.Log ("YESSS");
				//Application.LoadLevel("EndScene");
				animator.SetTrigger("GameOver");
				animator2.SetTrigger("GameOver");
				Debug.Log ("animation played");
			}

			Invoke ("continueRolling", timeStopped);
			
		}
	}
	void continueRolling(){
		cart.continueState ();
	}
}
