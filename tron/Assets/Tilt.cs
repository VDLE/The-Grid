using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Tilt : MonoBehaviour {

    float delay = 0;
    public GameObject tracked;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void FixedUpdate() {
        float h = tracked.transform.eulerAngles.z;//-CrossPlatformInputManager.GetAxis("Horizontal");
        if (tracked.transform.rotation.eulerAngles.z < 180  )
        {
            h = h / 90;
            h = Mathf.Clamp(h, 0, 1);
        }
        else if (tracked.transform.rotation.eulerAngles.z > 180)
        {
            h = -(1 - ((h - 270) / 90));
            h = Mathf.Clamp(h, -1, 0);
        }

       
        float deltaChange = (delay - 10 * h) * 2 * Time.deltaTime;
        delay -= deltaChange * .5f; 
        delay = Mathf.Clamp(delay, -10,10);
        Vector2 origin = new Vector2(transform.eulerAngles.x, transform.eulerAngles.y);
        transform.eulerAngles = new Vector3(origin.x, origin.y, delay);
       // Debug.Log(deltaChange+" "+h);
        AxisManager.turn = h;
	}
}
