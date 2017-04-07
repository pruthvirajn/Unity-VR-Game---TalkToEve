using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public float speed = 20.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Vertical") * speed;
		transform.Translate (0,0, translation * Time.deltaTime);
	}
}
