using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour {
    public int health;
    private DirtController dirt;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            dirt.SetEmpty();
            Destroy(gameObject);
        }
        
	}

    public void setHealth(int h)
    {
        health = h;
    }

    public int getHealth()
    {
        return health;
    }

    public void setDirt(DirtController newdirt)
    {
        dirt = newdirt;
    }
}
