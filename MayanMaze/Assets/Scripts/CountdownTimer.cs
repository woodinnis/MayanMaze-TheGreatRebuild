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

	// Use this for initialization
	void Start () {

        print(startAtSceneIndex);

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
            }
        }
    }

    void OnLevelWasLoaded()
    {
        if (SceneManager.GetActiveScene().buildIndex >= startAtSceneIndex)
        {
            countdownTarget = countdownTime;
            timerText = GetComponentInChildren<Text>();
            currentPlayer = FindObjectOfType<Player>();
            currentPlayer.enabled = false;
            timerText.enabled = true;
        }

    }
}
