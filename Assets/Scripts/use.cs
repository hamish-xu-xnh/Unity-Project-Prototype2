﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class use : MonoBehaviour {
    

	public void useMe()
	{
		if (System.Int32.Parse (this.transform.Find ("Text").GetComponent<Text> ().text) >= 1) {
			int tcount = System.Int32.Parse (this.transform.Find ("Text").GetComponent<Text> ().text) - 1;
			this.transform.Find ("Text").GetComponent<Text> ().text = "" + tcount;
		}
        //else
			//Destroy (this.gameObject);
	}
}
