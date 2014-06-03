using UnityEngine;
using System.Collections;

public class BarrelCtrl : MonoBehaviour {
	public GameObject expEffect;
	public Texture[] _texture;
	public static int BarrelCount;
	public static int totalHit;
	public static int score;
	private Transform tr;
	public GUIText barrelCount;
	public GUIText barrelHit;
	public GUIText guiScore;
	public static string barrelHitContext = "Barrel Hit : ";
	public static string barrelCountContext = "Barrel Left : ";
	public static string scoreText = "Score : ";


	private int hitCount = 0;
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();

		BarrelCount++;

		barrelCount.text = barrelCountContext + BarrelCount;
	}

	void OnCollisionEnter(Collision coll){
		if (coll.collider.tag == "BULLET") {
			Destroy(coll.gameObject);
			if(hitCount < 10){
				totalHit++;
			}

			barrelHit.text = barrelHitContext + totalHit;


			if(++hitCount >= 10){

				StartCoroutine(this.ExplosionBarrel());
			}
		}
	}
	IEnumerator ExplosionBarrel(){
		Instantiate (expEffect, tr.position, Quaternion.identity);

		Collider[] colls = Physics.OverlapSphere (tr.position, 10.0f);

		foreach (Collider coll in colls) {
			if (coll.rigidbody != null){
				coll.rigidbody.mass = 5.0f;
				coll.rigidbody.AddExplosionForce(800.0f, tr.position, 10.0f, 300.0f);
			}
		}
		if (hitCount == 10) {
			BarrelCount--;
			score += UnityBridge.BarrelScore(this.tag);
			guiScore.text = scoreText + score;
		}
		
		barrelCount.text = barrelCountContext + BarrelCount;

		Destroy (gameObject, 5.0f);
		yield return null;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
