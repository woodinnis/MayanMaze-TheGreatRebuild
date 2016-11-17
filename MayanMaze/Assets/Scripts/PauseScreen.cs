using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScreen : MonoBehaviour {

    private Text pauseText;
    private PauseButton pauseButton;
    private MenuButton menuButton;
    private RestartButton restartButton;

    //  I Cannot currently make a panel work the way I'd like to, so I'm leaving the Canvas out for now.
    //    private Canvas pauseCanvas;

    private Arrow[] arrows;
    private Player player;

    private bool gameIsPaused;

	// Use this for initialization
	void Start () {
        pauseText = GetComponentInChildren<Text>();

        pauseButton = GetComponentInChildren<PauseButton>();
        menuButton = GetComponentInChildren<MenuButton>();
        restartButton = GetComponentInChildren<RestartButton>();
        //  pauseCanvas = GetComponent<Canvas>();

        arrows = FindObjectsOfType<Arrow>();
        player = FindObjectOfType<Player>();

        gameIsPaused = false;
        ButtonHandler();

        //pauseCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update() {
        if (Input.GetKeyDown("space"))
        {
            PauseFunction();
        }
	}

    //  The pause function disables primary game elements
    public void PauseFunction()
    {

        if (!gameIsPaused)
        {
            //pauseCanvas.enabled = true;
            player.enabled = false;
            player.GetComponent<SpriteRenderer>().enabled = false;
            pauseText.text = "PAUSED";
            foreach (Arrow tile in arrows)
            {
                tile.enabled = false;
                tile.GetComponent<SpriteRenderer>().enabled = false;
            }
            gameIsPaused = true;
            ButtonHandler();
        }
        else
        {
            //pauseCanvas.enabled = false;
            player.enabled = true;
            player.GetComponent<SpriteRenderer>().enabled = true;
            pauseText.text = "";
            foreach (Arrow tile in arrows)
            {
                tile.enabled = true;
                tile.GetComponent<SpriteRenderer>().enabled = true;
            }
            gameIsPaused = false;
            ButtonHandler();
        }
    }

    void ButtonHandler()
    {
        if (!gameIsPaused)
        {
            restartButton.enabled = false;
            restartButton.GetComponent<Image>().enabled = false;
            menuButton.enabled = false;
            menuButton.GetComponent<Image>().enabled = false;
        }
        else
        {
            restartButton.enabled = true;
            restartButton.GetComponent<Image>().enabled = true;
            menuButton.enabled = true;
            menuButton.GetComponent<Image>().enabled = true;
        }
    }
}
