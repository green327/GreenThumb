using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Bullet")
            Destroy(col.gameObject);
    }
}
