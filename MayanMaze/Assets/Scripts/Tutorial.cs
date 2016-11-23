using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : MonoBehaviour {

    public string[] checkLevels;
    public Text[] tutorialMessages;

    private LevelManager levelManager;
    private Text text;
    private PauseScreen pauseScreen;

	// Use this for initialization
	void Start ()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        pauseScreen = FindObjectOfType<PauseScreen>();
        text = GetComponentInChildren<Text>();

        DisplayCurrentTutorial();
    }

    private void Update()
    {
        CountdownTimer countDown = FindObjectOfType<CountdownTimer>();

        if (countDown.countdownTarget <= 0f)
        {
            Canvas myCanvas = GetComponentInParent<Canvas>();
            myCanvas.enabled = false;
        }
    }

    private void DisplayCurrentTutorial()
    {
        string currentLevel = levelManager.GetCurrentLevel();

        int index = 0;

        //  Search each array element
        foreach (string level in checkLevels)
        {
            //  When a matching level name and tutorial message are found, display the message.
            if (level == currentLevel)
            {
                //pauseScreen.PauseFunction();
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
