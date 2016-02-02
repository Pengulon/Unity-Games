using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Song_Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.PlayDelayed (4.6f);
	}

}
