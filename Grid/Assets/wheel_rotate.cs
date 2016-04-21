using UnityEngine;
using System.Collections;

public class wheel_rotate : MonoBehaviour {

	float time;
	Vector3 center;

	// Use this for initialization
	void Start () {
		center = gameObject.transform.localPosition - new Vector3(0,.4f,0);
		//gameObject.transform.position = center + new Vector3 (0, .001f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		center = gameObject.transform.localPosition - new Vector3(0,.4f,0);
		gameObject.transform.RotateAround (Vector3.zero, new Vector3 (1, 0, 0), time);
		time += Time.deltaTime;
	}
}
