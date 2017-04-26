using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIfNeeded : MonoBehaviour {

	[SerializeField] int LOOK_AWAY_TIME_TO_MOVE = 2;
	[SerializeField] int speed;
	GvrReticlePointerImpl pointer;
	Camera camera;
	bool isMoving = false;

	// Use this for initialization
	void Start () {
		GvrReticlePointer pointer = GetComponentInChildren<GvrReticlePointer> ();
		this.pointer = pointer.reticlePointerImpl;
		camera = Camera.main;
		speed = 40;
	}
	
	// Update is called once per frame
	void Update () {
		if (pointer.isExpanded == false && isMoving == false) {
			Invoke ("Move", LOOK_AWAY_TIME_TO_MOVE);
		} else {
			CancelInvoke ();
			isMoving = false;
		}
	}

	void Move() {
		isMoving = true;
		transform.Translate (camera.transform.forward * Time.deltaTime * speed);
	}
}
