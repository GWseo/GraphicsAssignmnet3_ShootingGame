﻿using UnityEngine;
using System.Collections;

public class BulletCtrl : MonoBehaviour {
	public int damage = 20;
	public float speed = 1500.0f;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (transform.forward * speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
