using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float waitTime = 30f;

    public GameObject timerText;

    public float timer;

    private void Start()
    {
        timer = waitTime;    
    }

    void Update()
    {

        //timer counts down from wait time and sets the text field to that. if it's lower than 5 seconds it makes the color red.

        timer -= Time.deltaTime;
        timerText.GetComponent<TextMesh>().text = Mathf.Round(timer).ToString();
        if (timer < 5.1)
        {
            timerText.GetComponent<TextMesh>().color = Color.red;
        }
    }
}
