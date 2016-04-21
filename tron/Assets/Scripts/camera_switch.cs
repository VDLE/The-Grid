using UnityEngine;
using System.Collections;

public class camera_switch : MonoBehaviour {

	public Camera first;
	public Camera third;
	public UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			if (first.gameObject.activeInHierarchy) {
				player.cam = third;
				first.gameObject.SetActive (false);
				third.gameObject.SetActive (true);
			} else {
				player.cam = first;
				first.gameObject.SetActive (true);
				third.gameObject.SetActive (false);
			}
		}
	}
}
