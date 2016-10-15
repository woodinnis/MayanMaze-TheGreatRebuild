using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : MonoBehaviour {

    public Object[] checkLevels;
    public string[] tutorialMessages;

    private LevelManager levelManager;
    private Text text;

	// Use this for initialization
	void Start () {

        levelManager = GameObject.FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();

        string currentLevel = levelManager.GetCurrentLevel();

        int index = 0;

        //  Search each array element
        foreach(Object level in checkLevels)
        {
            //  When a matching level name and tutorial message are found, display the message.
            if(level.name == currentLevel)
            {
                text.text = tutorialMessages[index];
                break;
            }
            ++index;
        }
	}
}
