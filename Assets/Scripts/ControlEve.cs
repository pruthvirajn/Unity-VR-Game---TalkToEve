using UnityEngine;
using System.Collections;

public class ControlEve : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		GameObject dialogue = GameObject.Find ("Dialogue");
		dialogue.GetComponent<DialogueImplementation>().changeAnim += delegate(object sender, string animValue) {
			if(animValue == "jump"){
				anim.SetBool ("Jump", true);
			}
			else if(animValue == "death"){
				anim.SetBool ("Death", true);
			}
		};
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
