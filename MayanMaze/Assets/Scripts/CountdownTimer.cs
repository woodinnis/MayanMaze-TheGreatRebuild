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
    private PauseButton pauseButton;

	// Use this for initialization
	void Start () {

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
                currentPlayer.enabled = true;
                timerText.enabled = false;

                //  Enable pause button
                pauseButton.enabled = true;
            }
        }
    }

    void OnLevelWasLoaded()
    {
        //  Varify that the current scene is at or above the first scene requiring a timer
        if (SceneManager.GetActiveScene().buildIndex >= startAtSceneIndex)
        {
            //  Set the local countdown timer value
            countdownTarget = countdownTime;

            //  Disable the pause button
            pauseButton = FindObjectOfType<PauseButton>();
            pauseButton.enabled = false;

            //  Disable the player
            currentPlayer = FindObjectOfType<Player>();
            currentPlayer.enabled = false;

            //  Enable the timer text
            timerText = GetComponentInChildren<Text>();
            timerText.enabled = true;
        }

    }
}
