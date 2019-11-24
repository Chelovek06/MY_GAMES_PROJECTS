using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuAndScenes : MonoBehaviour
{
    public GameObject ButtonsMenu;
    public GameObject ButtonsExit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowExitButtons(){
        ButtonsMenu.SetActive(false);
        ButtonsExit.SetActive(true);
    }

    public void BackInMenu(){
        ButtonsMenu.SetActive(true);
        ButtonsExit.SetActive(false);
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void TpMainMenu(){
        Application.LoadLevel("MainMenu");
    }
}
