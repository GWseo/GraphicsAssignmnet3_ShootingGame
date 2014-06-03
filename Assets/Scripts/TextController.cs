using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class TextController : MonoBehaviour {
	public GUIText gt;	// Use this for initialization
	void Start () {
		gt.text = " : " + UnityBridge.Accurate(10,2);
		gt.text += UnityBridge.BarrelScore ("YELLOBARREL");
	}
}
