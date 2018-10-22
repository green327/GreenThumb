using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {
    public Text Bank;
    public Text Seeds;
    public Text Turrets;

    //Accesses Game Manager
    private GameObject[] gameArray;
    private GameObject game;
    private GameManager gm;

    //Interaction for Purchasing
    public Button[] seeds;
    public Button[] turrets;
    public Button[] upgrades;

	// Use this for initialization
	void Start ()
    {
        gameArray = GameObject.FindGameObjectsWithTag("GameManager");
        game = gameArray[0];

        gm = game.GetComponent<GameManager>();

        fillContent(gm.Level);

        ListenSeeds();
        ListenTurrets();
        ListenUpgrades();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Bank.text = gm.money.ToString();
        Seeds.text = gm.seeds.ToString();
        Turrets.text = gm.turrets.ToString();
    }

    void fillContent(int level)
    {
        for(int i = 0; i < level; ++i)
        {
            seeds[i].gameObject.SetActive(true);
            turrets[i].gameObject.SetActive(true);
            upgrades[i].gameObject.SetActive(true);
        }
    }

    void ListenSeeds()
    {
        for (int i = 0; i < seeds.Length; i++)
        {
            int closureIndex = i; // Prevents the closure problem
            seeds[closureIndex].onClick.AddListener(() => TaskOnClickSeed(closureIndex));
        }
    }
    public void TaskOnClickSeed(int buttonIndex)
    {
        Debug.Log("You have clicked the button #" + buttonIndex, seeds[buttonIndex]);
        if (gm.money >= 5)
        {
            gm.seeds++;
            gm.money -= 5;
        }
    }

    void ListenTurrets()
    {
        for (int i = 0; i < turrets.Length; i++)
        {
            int closureIndex = i; // Prevents the closure problem
            turrets[closureIndex].onClick.AddListener(() => TaskOnClickTurrets(closureIndex));
        }
    }
    public void TaskOnClickTurrets(int buttonIndex)
    {
        Debug.Log("You have clicked the button #" + buttonIndex, turrets[buttonIndex]);
        if (gm.money >= 10)
        {
            gm.turrets++;
            gm.money -= 10;
        }
    }

    void ListenUpgrades()
    {
        for (int i = 0; i < upgrades.Length; i++)
        {
            int closureIndex = i; // Prevents the closure problem
            upgrades[closureIndex].onClick.AddListener(() => TaskOnClickUpgrades(closureIndex));
        }
    }
    public void TaskOnClickUpgrades(int buttonIndex)
    {
        Debug.Log("You have clicked the button #" + buttonIndex, upgrades[buttonIndex]);
        if (gm.money >= 5)
        {
            //gm.seeds++;
        }
    }
}
