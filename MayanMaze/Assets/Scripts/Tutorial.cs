using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : GameUI {

    public string[] checkLevels;
    public Text[] tutorialMessages;

    private Text text;
    private CountdownTimer countDown;

    // Use this for initialization
    void Start ()
    {
        //base.Start();

        text = GetComponentInChildren<Text>();
        countDown = FindObjectOfType<CountdownTimer>();

        DisplayCurrentTutorial();
    }

    private void Update()
    {
        //  Remove tutorial from screen when walk countdown reaches 0
        if (countDown.countdownTarget <= 0f)
        {
            GameObject[] myCanvas = GameObject.FindGameObjectsWithTag("Tutorial");

            foreach (GameObject mC in myCanvas)
                mC.SetActive(false);
        }
    }

    private void DisplayCurrentTutorial()
    {
        string currentLevel = GameUI_LevelManager.GetCurrentLevelName();

        int index = 0;

        //  Search each array element
        foreach (string level in checkLevels)
        {
            //  When a matching level name and tutorial message are found, display the message.
            if (level == currentLevel)
            {
                text.text = tutorialMessages[index].text;
                break;
            }
            ++index;
        }
        if(index >= tutorialMessages.Length)
        {
            Canvas myCanvas = GetComponentInParent<Canvas>();
            myCanvas.enabled = false;
        }
    }
}
