using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Restart : MonoBehaviour {

    private Button button;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {

        button = GetComponent<Button>();

        levelManager = GameObject.FindObjectOfType<LevelManager>();

        button.onClick.AddListener(TaskOnClick);
	}
	
    void TaskOnClick()
    {
        levelManager.RestartLevel();
    }
}
