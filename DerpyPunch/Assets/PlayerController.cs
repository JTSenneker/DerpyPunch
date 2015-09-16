using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	float acceleration = 1f;
	float speedMax = 8f;
	float speedCurrent = 0f;
	float speedTarget = 0f;

	//Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {

		//rigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		float h = Input.GetAxisRaw ("Horizontal");
		float dt = Time.deltaTime;

		speedTarget = h * speedMax;
		if (speedCurrent != speedTarget) {
			if(speedCurrent < speedTarget){
				speedCurrent += acceleration * dt;
				if(speedCurrent > speedTarget) speedCurrent = speedTarget;
			} else {
				speedCurrent -= acceleration * dt;
				if(speedCurrent < speedTarget) speedCurrent = speedTarget;
			}
		}
		transform.Translate (speedCurrent, 0, 0);
	}
}
