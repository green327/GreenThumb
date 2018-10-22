using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolPickup : MonoBehaviour {

    private bool hasBeenGrabbed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerStay(Collider other)
    {
       // Debug.Log("in the ontriggerstay");
        if (other.tag == "Player" && !hasBeenGrabbed && Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("picking up object");
            gameObject.transform.parent = other.transform;
            gameObject.transform.position = other.transform.position;
            gameObject.transform.rotation = other.transform.rotation;

            hasBeenGrabbed = true;
        }

        else if (other.tag == "Player" && hasBeenGrabbed && Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("putting down object");
            gameObject.transform.parent = null;
            Vector3 newpos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
            gameObject.transform.position = newpos;
            hasBeenGrabbed = false;
        }
    }
}
