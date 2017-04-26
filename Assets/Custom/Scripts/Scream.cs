using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour {

	public GvrAudioSource scream;

	public void OnTapped() {
		scream.Play ();
		Invoke ("Run", scream.clip.length);
	}

	public void onLookAway() {
		scream.Stop ();
		CancelInvoke ();
	}

	private void Run() {
		gameObject.SetActive (false);
	}
}
