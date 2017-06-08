using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameUI : MonoBehaviour {

    public RectTransform GameUI_RectTransform;
    public LevelManager GameUI_LevelManager;

    // The UI needs to share a single Countdown time between all elements
    public CountdownTimer GameUI_CountdownTimer;

	// Use this for initialization
	public void Awake () {

        GameUI_LevelManager = FindObjectOfType<LevelManager>();
        GameUI_RectTransform = GetComponent<RectTransform>();

        GameUI_CountdownTimer = FindObjectOfType<CountdownTimer>();
	}
}
