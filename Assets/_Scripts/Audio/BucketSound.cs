﻿using UnityEngine;
using System.Collections;

public class BucketSound : MonoBehaviour {

    public AudioClip scoop;
    public AudioClip clothigMovement;
    private AudioSource bucketSound;

	// Use this for initialization
	void Awake () {
        bucketSound = GetComponent<AudioSource>();
	}
	
    public void playWaterScoop()
    {
        bucketSound.PlayOneShot(scoop);
    }

    public void playClothMovement()
    {
        bucketSound.PlayOneShot(clothigMovement);
    }
	
}