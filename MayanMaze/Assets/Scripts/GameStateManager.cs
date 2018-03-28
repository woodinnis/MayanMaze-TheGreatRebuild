using UnityEngine;
using System.Collections;

public class GameStateManager : MonoBehaviour {

    public enum GameState { MENU, PLAY, PAUSE, COMPLETE, GAMEOVER}

    public GameState gameState;

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
