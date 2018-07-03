using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

	Animator anim;
 	public static carController instance;

	
	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	
	void Start () {
 
		for (int i = 0; i < transform.childCount; ++i) {
			
			
 			if (transform.GetChild (i).gameObject.name == gameController.currentSelectedCar) {
				transform.GetChild (i).gameObject.SetActive (true);

				
				anim = transform.GetChild (i).gameObject.GetComponent<Animator> ();
			} else {
				
				transform.GetChild (i).gameObject.SetActive (false);
			}
 		}

		 
	}

	
 	public void triggerAnimation(string action){
		anim.SetTrigger (action);
	}

	public void showMessage(){
		//TODO
	}

}
