using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//https://docs.unity3d.com/2017.4/Documentation/ScriptReference/Transform.Rotate.html


public class GameManager : MonoBehaviour {
    public int Level;
    public Text txt;

    public int money;
    public int seeds;
    public int turrets;

    //Day Cycle Parameter
    public int DayLength;

    //Spawner Parameters
    public int WaveStarTime;
    public int EnemyCount;

    //DayNight Cycle Management
    public GameObject daynight;
    private Cycle cycle;

    //Spawner Management
    public GameObject[] spawners;
    private EnemySpawning spawn;

    private bool NightLoaded;
    // Use this for initialization
    void Start ()
    {
        Level = 1;
        LoadMain();

        NightLoaded = false;
    }

    private void Awake()
    {
        LoadMain();
    }

    // Update is called once per frame
    void Update ()
    {
        if (DayLength <= cycle.timer && !NightLoaded)
        {
            Debug.Log("Starting Night");
            NightLoaded = true;
            LoadNight();
        }
    }

    void LoadMain()
    {
        NightLoaded = false;
        txt.text = Level.ToString();

        cycle = daynight.GetComponent<Cycle>();
        cycle.waveLength = DayLength;

        for(int i = 0; i < spawners.Length; ++i)
        {
            spawners[i].GetComponent<EnemySpawning>().enemyCap = EnemyCount;
            spawners[i].GetComponent<EnemySpawning>().startWait = WaveStarTime;
        }
    }

    void LoadNight()
    {
        Level++;
        SceneManager.LoadScene("Shop", LoadSceneMode.Single);
    }
}
