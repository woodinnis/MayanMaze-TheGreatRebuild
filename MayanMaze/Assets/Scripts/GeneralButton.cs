﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GeneralButton : MonoBehaviour {

    public enum ButtonType { MENU, PAUSE, RESTART, CONTINUE };

    public ButtonType buttonType;

    private Button button;
    
    // Use this for initialization
    void Start() {
        
        button = GetComponent<Button>();

        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //  Perform the selected button operation
        switch (buttonType)
        {
            case ButtonType.MENU:
                {
                    LevelManager levelManager = FindObjectOfType<LevelManager>();
                    levelManager.LoadStartMenu();
                    break;
                }
            case ButtonType.PAUSE:
                {
                    PauseScreen pauseScreen = FindObjectOfType<PauseScreen>();
                    pauseScreen.PauseFunction();
                    break;
                }
            case ButtonType.RESTART:
                {
                    LevelManager levelManager = FindObjectOfType<LevelManager>();
                    levelManager.RestartLevel();
                    break;
                }
            case ButtonType.CONTINUE:
                {
                    GameObject[] myCanvas = GameObject.FindGameObjectsWithTag("Tutorial");

                    foreach (GameObject mC in myCanvas)
                        mC.SetActive(false);

                    break;
                }
        }
    }
}
