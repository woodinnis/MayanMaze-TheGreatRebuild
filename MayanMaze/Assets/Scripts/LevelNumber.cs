using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelNumber : MonoBehaviour {

    public Object[] levels;

    private Text text;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        //  Get the name of the current level
        string currentLevel = levelManager.GetCurrentLevel();

        int index = 0;

        //  Search each array element
        foreach(Object item in levels)
        {
            string testLevel = item.name;

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
