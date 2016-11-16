using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScreen : MonoBehaviour {

    private Text pauseText;
    private PauseButton pauseButton;
    private MenuButton menuButton;
    private RestartButton restartButton;

    private Arrow[] arrows;
    private Player player;

    private bool gameIsPaused;

	// Use this for initialization
	void Start () {
        pauseText = GetComponentInChildren<Text>();

        pauseButton = GetComponentInChildren<PauseButton>();
        menuButton = GetComponentInChildren<MenuButton>();
        restartButton = GetComponentInChildren<RestartButton>();

        arrows = FindObjectsOfType<Arrow>();
        player = FindObjectOfType<Player>();

        gameIsPaused = false;
	}
	
	// Update is called once per frame
	void Update() {
        if (Input.GetKeyDown("space"))
            PauseFunction();
	}

    //  The pause function disables primary game elements
    void PauseFunction()
    {

        if (!gameIsPaused)
        {
            player.enabled = false;
            player.GetComponent<SpriteRenderer>().enabled = false;
            pauseText.text = "This is not a potato";
            foreach (Arrow tile in arrows)
            {
                tile.enabled = false;
                tile.GetComponent<SpriteRenderer>().enabled = false;
            }
            gameIsPaused = true;
        }
        else
        {
            player.enabled = true;
            player.GetComponent<SpriteRenderer>().enabled = true;
            pauseText.text = "You May Play Now";
            foreach (Arrow tile in arrows)
            {
                tile.enabled = true;
                tile.GetComponent<SpriteRenderer>().enabled = true;
            }
            gameIsPaused = false;
        }
    }
}
