using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;

public class DownKeyChecker : MonoBehaviour {

		public Text displayKeyEventValue;

	// Use this for initialization
	void Start () {

	}

	void Update () {
			DownKeyCheck ();
	}


	void DownKeyCheck(){
			if (Input.anyKeyDown) {
					foreach (KeyCode code in Enum.GetValues(typeof(KeyCode))) {
							if (Input.GetKeyDown (code)) {
								displayKeyEventValue.text = code.ToString ();
							}
					}
			}
	}
}
