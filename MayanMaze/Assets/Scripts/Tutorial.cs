using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : GameUI {

    public string scenesFolder;
    public string[] checkLevels;
    public Text[] tutorialMessages;

    private Text text;
    
    // Use this for initialization
    void Start ()
    {
        text = GetComponentInChildren<Text>();

        print(GetComponentInParent<Canvas>().name);
        DisplayCurrentTutorial();
    }

    void Update()
    {
        //  Remove tutorial from screen when GameUI Countdown Timer reaches 0
        if (GameUI_CountdownTimer.countdownTarget <= 0f)
        {
            DisableTutorial();
        }
    }

    private void DisplayCurrentTutorial()
    {
        string currentLevel = GameUI_LevelManager.GetCurrentLevelName();
        Debug.Log("Current Level: " + currentLevel);
        int index = 0;

        //  Search each array element
        foreach (string level in checkLevels)
        {
            Debug.Log("Checking Level: " + scenesFolder + level);
            //  When a matching level name and tutorial message are found, display the message.
            if (scenesFolder + level == currentLevel)
            {
                text.text = tutorialMessages[index].text;
                break;
            }
            ++index;
        }

        //  If no tutorial message can be found for this level, disable the tutorial screen
        if (index >= tutorialMessages.Length)
        {
            DisableTutorial();
        }
    }

    //  Disable the tutorial message
    private static void DisableTutorial()
    {
        GameObject disableMe = GameObject.FindGameObjectWithTag("Tutorial");
        disableMe.SetActive(false);
    }

}
