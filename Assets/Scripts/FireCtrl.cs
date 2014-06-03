using UnityEngine;
using System.Collections;

public class FireCtrl : MonoBehaviour {
	public GameObject bullet;
	public Transform firePos;
	
	public GUIText bulltCountText;
	public GUIText accurateText;
	private static int count;
	private static string bulltCount = "Bullet Count : ";
	private static string accurate = "Accurate : ";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Fire ();
		}

		bulltCountText.text = bulltCount + count;
		
		accurateText.text = accurate + UnityBridge.Accurate(BarrelCtrl.totalHit, count)*100 + "%";

	}

	void Fire(){
		StartCoroutine (this.CreatBullet ());
	}
	IEnumerator CreatBullet(){
		Instantiate (bullet, firePos.position, firePos.rotation);
		count++;
		yield return null;
	}
}
