using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelNumber : MonoBehaviour {

    public int startAtLevel;
    public int buildIndexBuffer;

    private int startAtSceneIndex;

	// Use this for initialization
	void Start ()
    {
        //  Set the scene index to begin counting levels based on the level number
        startAtSceneIndex = startAtLevel + buildIndexBuffer;
    }

    void OnLevelWasLoaded()
    {
        //  Call at the beginning of each level
        DisplayCurrentLevel();
    }

    private void DisplayCurrentLevel()
    {
        //  Acquire the text component of the Level indicator
        Text text;
        text = GetComponent<Text>();

        //  Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        //  Display the current level
        if (currentSceneIndex >= startAtSceneIndex)
        {
            string testLevel = (currentSceneIndex - buildIndexBuffer).ToString();
            text.text = testLevel;
        }
    }
}
