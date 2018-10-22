using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBox : MonoBehaviour {

    public int SellsFor = 5;
    public GameObject moneyText;
    public GameManager gm;

    private float timer;

	// Use this for initialization
	void Start () {
        //gm = game.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if(timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            moneyText.SetActive(false);
        }
		
	}

    private void OnTriggerStay(Collider other)
    {
        //drop fruit in sell box, add money and display it
        if (other.tag == "Plant" && Input.GetKey(KeyCode.E))
        {
            gm.money += 5;
            Destroy(other.gameObject);
            timer = 2;
            moneyText.GetComponent<TextMesh>().text = "+" + SellsFor;
            moneyText.SetActive(true);
        }
    }
}
