using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    //  Declare private variables
    private Button button;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {

        //  Initialize variables
        button = GetComponent<Button>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        button.onClick.AddListener(TaskOnClick);
    }

    //  Perform when button is clicked
    void TaskOnClick()
    {
        switch (tag)
        {
            //  For the Start button
            case "StartButton":
                levelManager.LoadNextLevel();
                break;
            //  For the Quit button
            case "QuitButton":
                print("I QUIT!");
                break;
            default:
                break;
        }
    }
}
