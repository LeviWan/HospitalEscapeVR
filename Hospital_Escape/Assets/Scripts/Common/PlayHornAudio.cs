using UnityEngine;
using System.Collections;

public class PlayHornAudio : MonoBehaviour {

    private AudioSource audio;
    private bool isPlayAudio = false;
	void Start () {
        audio = this.GetComponent<AudioSource>();
	}

    void OnTriggerEnter(Collider co)
    {
        if (isPlayAudio==false)
        {
            audio.Play();
            isPlayAudio = true;
        }
    }
    void OnTriggerExit(Collider co)
    {
        isPlayAudio = false;
    }
}
