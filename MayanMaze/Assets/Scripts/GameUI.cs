using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameUI : MonoBehaviour {

    public RectTransform GameUI_RectTransform;
    public LevelManager GameUI_LevelManager;

	// Use this for initialization
	public void Start () {

        GameUI_LevelManager = FindObjectOfType<LevelManager>();
        GameUI_RectTransform = GetComponent<RectTransform>();
	}
}
