using UnityEngine;
using System.Collections;

public class Light_Timer : MonoBehaviour {

    float totalTime = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime; 
        if(totalTime >= 5.0f)
        {
            Destroy(gameObject);
        }
    }
}
