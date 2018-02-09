using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackeysTestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI() {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "PlaySound")) {
            BrackeysAudioManager.Instance.PlaySound("TestSoundEffect");
        }


    }
}
