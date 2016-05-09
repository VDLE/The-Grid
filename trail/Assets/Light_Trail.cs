using UnityEngine;
using System.Collections;

public class Light_Trail : MonoBehaviour {

    public GameObject prefab;
    public GameObject bike;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject trailObj = Instantiate(prefab, transform.position-transform.forward*3, bike.transform.rotation) as GameObject;
        trailObj.AddComponent<Light_Timer>();
    }
}
