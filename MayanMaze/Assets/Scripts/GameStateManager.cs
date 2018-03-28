using UnityEngine;
using System.Collections;

public class GameStateManager : MonoBehaviour {

    // Keep the GameStateManager in all subsequent scenes
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
