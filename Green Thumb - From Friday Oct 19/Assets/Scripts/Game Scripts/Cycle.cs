using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycle : MonoBehaviour {

    public float waveLength;
    public float timer;

    private float rotationSpeed;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        //Tracks the total time elapsed
        timer += Time.deltaTime;

        //calculates how fast the object needs to rotate in order to match the wave length
        rotationSpeed = (180 * Time.deltaTime)/ waveLength;
        transform.Rotate(0, 0, rotationSpeed);
    }

    void ResetTimer()
    {
        timer = 0;
    }
}
