using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnMouseDown()
    {
        levelManager.RestartLevel();
    }
}
