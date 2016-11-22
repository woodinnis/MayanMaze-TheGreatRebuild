using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CountdownTimer : MonoBehaviour {

    public string countdownMessage;
    public float countdownTime;
    public int startAtSceneIndex;    

    private Text timerText;
    private Player currentPlayer;
    private float countdownTarget;
    private GeneralButton[] generalButtons;

	// Use this for initialization
	void Start () {
        generalButtons = FindObjectsOfType<GeneralButton>();
	}

    void OnLevelWasLoaded()
    {
        //  Varify that the current scene is at or above the first scene requiring a timer
        if (SceneManager.GetActiveScene().buildIndex >= startAtSceneIndex)
        {
            //  Set the local countdown timer value
            countdownTarget = countdownTime;

            //  Disable the pause button
            foreach(GeneralButton gB in generalButtons)
            {
                print(gB.name);
                //if (gB.buttonType == GeneralButton.ButtonType.PAUSE)
                    //print(gB.name);
            }
            //pauseButton = FindObjectOfType<GeneralButton>();

            //  Disable the player
            currentPlayer = FindObjectOfType<Player>();
//            currentPlayer.enabled = false;

            //  Enable the timer text
            timerText = GetComponentInChildren<Text>();
            timerText.enabled = true;
        }

    }

    // Update is called once per frame
    void Update () {

        //  Verify that the current scene is at or beyond the first scene requiring a timer
        if (SceneManager.GetActiveScene().buildIndex >= startAtSceneIndex)
        {
            //  Begin the timer
            timerText.text = countdownMessage + " " + Mathf.Round(countdownTarget);
            if(countdownTarget >= 0)
                countdownTarget -= Time.deltaTime;

            //  When the timer reaches 0 reenable player actions and clear the text field
            if (countdownTarget < 0)
            {
//                currentPlayer.enabled = true;
                timerText.enabled = false;

                //  Enable pause button
                foreach (GeneralButton gB in generalButtons)
                {
                    if (gB.buttonType == GeneralButton.ButtonType.PAUSE)
                        gB.enabled = true;
                }
            }
        }
    }
}
