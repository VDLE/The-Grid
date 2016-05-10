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

        if (!gameObject.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().Dead)
        {
            GameObject trailObj = Instantiate(prefab, transform.position - transform.forward * 5, bike.transform.rotation) as GameObject;
            trailObj.AddComponent<Light_Timer>();
        }
    }
}
