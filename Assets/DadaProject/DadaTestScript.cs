using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadaTestScript : MonoBehaviour {


    public AudioClip clipOnGameObject;


    private void OnGUI() {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 50), "Play2DSound")) {
            CS_AudioManager.Instance.PlaySFX(clipOnGameObject);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, 100, 100, 50), "Play3DSound")) {
            Vector3 sfxPos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
            CS_AudioManager.Instance.Play3DSFX(CS_AudioManager.Instance.getMoney, sfxPos);
        }
    }


    
}
