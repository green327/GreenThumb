using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nighttime : MonoBehaviour {
    public Button Begin;
    public Button Quit;
    public Button shop;
    public Button nextDay;
    public Button menu;
    public Button settings;
    public Button NightMenu;

    public Canvas Shop;
    public Canvas Settings;
    public Canvas MainMenu;
    public Canvas Night;

    // Use this for initialization
    void Start ()
    {
        MainMenu.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        Shop.gameObject.SetActive(false);
        Night.gameObject.SetActive(true);

        shop.onClick.AddListener(onClickShop);
        nextDay.onClick.AddListener(onClicknextDay);
        menu.onClick.AddListener(onClickMenu);
        NightMenu.onClick.AddListener(onClickNight);
        settings.onClick.AddListener(onClickSettings);
        Begin.onClick.AddListener(onClickBegin);
        Quit.onClick.AddListener(onClickQuit);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void onClickNight()
    {
        MainMenu.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        Shop.gameObject.SetActive(false);
        Night.gameObject.SetActive(true);
    }

    void onClicknextDay()
    {
        SceneManager.LoadScene("Mega Boss Main Scene", LoadSceneMode.Single);
    }

    void onClickShop()
    {
        MainMenu.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        Night.gameObject.SetActive(false);
        Shop.gameObject.SetActive(true);

        Debug.Log(Shop);
    }

    void onClickMenu()
    {
        MainMenu.gameObject.SetActive(true);
        Settings.gameObject.SetActive(false);
        Shop.gameObject.SetActive(false);
        Night.gameObject.SetActive(false);
    }

    void onClickSettings()
    {
        //MainMenu.gameObject.SetActive(false);
        //Settings.gameObject.SetActive(true);
        //Shop.gameObject.SetActive(false);
        //Night.gameObject.SetActive(false);
    }

    void onClickBegin()
    {
        SceneManager.LoadScene("Mega Boss Main Scene", LoadSceneMode.Single);
    }

    void onClickQuit()
    {
        Application.Quit();
    }
}
