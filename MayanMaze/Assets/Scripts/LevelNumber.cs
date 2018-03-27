using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelNumber : GameUI {

    public int startAtLevel;
    public int buildIndexBuffer;

    private int startAtSceneIndex;
    private Text text;

    private const string levelDisplayString = "Level: ";

    void Start()
    {
        //  Acquire the text component of the Level indicator
        text = GetComponentInChildren<Text>();

        DisplayCurrentLevel();
    }
     
    void Update()
    {
        //  When the GameUI countdown timer reaches 0, disable the level number
        if (GameUI_CountdownTimer.countdownTarget <= 0f)
        {
            text.enabled = false;
        }
    }

    //  Display the current level number on screen
    private void DisplayCurrentLevel()
    {
        //  If the current Scene index is within the scope of the level counter display the level number
        if(GameUI_LevelManager.GetCurrentLevelIndex() >= startAtLevel)
        {
            int currentLevelNumber = GameUI_LevelManager.GetCurrentLevelNumber();
            text.text = (levelDisplayString + currentLevelNumber.ToString());
        }
    }
}
