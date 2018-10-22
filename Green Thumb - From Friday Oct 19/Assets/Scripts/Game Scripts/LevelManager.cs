using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    private GameManager gm;
    public GameObject game;

    public Text Bank;
    public Text Seeds;
    public Text Turrets;
	// Use this for initialization
	void Start () {
        gm = game.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Bank.text = "Bank: " + gm.money.ToString();
        Seeds.text = "Seeds: " + gm.seeds.ToString();
        Turrets.text = "Turrets: " + gm.turrets.ToString();
    }
}
