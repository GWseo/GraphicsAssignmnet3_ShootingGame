using UnityEngine;
using System.Collections;

public class WallCtrl : MonoBehaviour {
	void OnCollisionEnter(Collision coll){
		if (coll.collider.tag == "BULLET") {
			Destroy (coll.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
