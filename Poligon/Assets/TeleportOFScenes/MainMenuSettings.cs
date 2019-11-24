using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSettings : MonoBehaviour
{
    public GameObject StartGame;
    public GameObject Settings;
    public GameObject Statistick;
    public GameObject Inventory;
    public GameObject Achievements;
    public GameObject Shop;
    public GameObject Modes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPlaying(){
        Application.LoadLevel("SampleScene");
    }

    public void BackSettings(){
        Application.LoadLevel("SETTINGS");
    }
}
