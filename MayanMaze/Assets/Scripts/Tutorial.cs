using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : MonoBehaviour {

    public string[] checkLevels;
    public Text[] tutorialMessages;

    private LevelManager levelManager;
    private Text text;

	// Use this for initialization
	void Start ()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        text = GetComponentInChildren<Text>();

        DisplayCurrentTutorial();
    }

    private void Update()
    {
        CountdownTimer countDown = FindObjectOfType<CountdownTimer>();

        if (countDown.countdownTarget <= 0f)
        {
            GameObject[] myCanvas = GameObject.FindGameObjectsWithTag("Tutorial");

            foreach (GameObject mC in myCanvas)
                mC.SetActive(false);
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
