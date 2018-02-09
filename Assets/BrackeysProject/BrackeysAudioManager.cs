using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound {

    public string name;
    public AudioClip clip;

	[Range(0f, 1f)]
    public float volume = 0.7f;
    [Range(0.5f, 2f)]
    public float pitch = 1f;

    [Range (-0.5f, 0f)]
    public float volumeJitterLow = 0.05f;
    [Range(0f, 0.5f)]
    public float volumeJitterHigh = 0.05f;
    [Range(-0.5f, 0f)]
    public float pitchJitterLow = 0.05f;
    [Range(0f, 0.5f)]
    public float pitchJitterHigh = 0.05f;

    private AudioSource source;


    public void SetSource (AudioSource _source) {
        source = _source;
        source.clip = clip;
    }

    public void Play() {
        source.volume = Random.Range(volume + volumeJitterLow, volume+volumeJitterHigh);
        source.pitch = Random.Range(pitch + pitchJitterLow, pitch + pitchJitterHigh);
        source.Play();
    }



}

public class BrackeysAudioManager : MonoBehaviour {

    public static BrackeysAudioManager Instance;

    [SerializeField]
    Sound[] sounds;

    void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
        } else  {
            Instance = this;
        }
    }

    void Start() {
        for (int i = 0; i < sounds.Length; i ++) {
            GameObject _go = new GameObject("Sound_" + i + "_" + sounds[i].name);
            _go.AddComponent<AudioSource>();
            sounds[i].SetSource(_go.AddComponent<AudioSource>());
        }
    }

    public void PlaySound (string _name) {
        for (int i = 0; i < sounds.Length; i ++) {
            if(sounds[i].name == _name) {
                sounds[i].Play();  
            }
        }

        //no sound with that name
        Debug.LogWarning("sound not found in array");
    }

}
