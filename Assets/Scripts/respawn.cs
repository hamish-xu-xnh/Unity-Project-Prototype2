﻿using System.Collections;
using UnityEngine;

public class respawn : MonoBehaviour {

	void OnCollisionEnter()
	{
		this.GetComponent<SphereCollider> ().enabled = false;
		this.GetComponent<MeshRenderer> ().enabled = false;
		Invoke ("Respawn", 10);
	}

	void Respawn()
	{
		this.GetComponent<SphereCollider> ().enabled = true;
		this.GetComponent<MeshRenderer> ().enabled = true;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
