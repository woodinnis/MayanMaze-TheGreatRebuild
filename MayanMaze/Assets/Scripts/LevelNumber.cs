using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelNumber : MonoBehaviour {

    public string[] levels;

    private Text text;
    private LevelManager levelManager;

	// Use this for initialization
	void Start ()
    {
        DisplayCurrentLevel();
    }

    private void DisplayCurrentLevel()
    {
        text = GetComponent<Text>();
        levelManager = FindObjectOfType<LevelManager>();

        //  Get the name of the current level
        string currentLevel = levelManager.GetCurrentLevel();

        int index = 0;

        //  Search each array element
        foreach (string item in levels)
        {
            string testLevel = item;

            //  When the current level is located, set the LevelNumber.Text to the coinciding value in the array
            if (testLevel == currentLevel)
            {
                text.text = index.ToString();
                break;  // Exit the loop
            }

            ++index;
        }
    }
}
