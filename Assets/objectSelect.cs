using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class objectSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print (CrossPlatformInputManager.GetAxis ("Horizontal"));	
	}
}
