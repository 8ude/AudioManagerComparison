using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//note inclusion of namespace
using Hang.AiryAudio;

public class AiryTestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI() {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "PlaySound")) {
            AiryAudioSource newSource = AiryAudioManager.Instance.InitAudioSource("TestSFX1");
            AiryAudioActions.Play(newSource);
        }


    }
}
