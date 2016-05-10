using UnityEngine;
using System.Collections;

public class Random_Explode : MonoBehaviour {

    float total = 0.0f;
    Vector3 direction;

	// Use this for initialization
	void Start () {
        direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
	}
	
	// Update is called once per frame
	void Update () {
        total += Time.deltaTime;
        transform.position = new Vector3(transform.position.x + Time.deltaTime*5*direction.x, transform.position.y + Time.deltaTime * 5 * direction.y, transform.position.z + Time.deltaTime * 5 * direction.z);

        if(total > 3)
        {
            Destroy(gameObject);
        }
	}
}
