using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScreen : MonoBehaviour {

    private Text pauseText;
    private PauseButton pauseButton;
    private MenuButton menuButton;
    private RestartButton restartButton;
    private Text countdownText;

    private float playerMoveSpeed;

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

        countdownTimer = FindObjectOfType<CountdownTimer>();
        countdownText = countdownTimer.GetComponentInChildren<Text>();

        arrows = FindObjectsOfType<Arrow>();
        player = FindObjectOfType<Player>();

        playerMoveSpeed = player.playerMoveSpeed;

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
            gameIsPaused = true;

            //pauseCanvas.enabled = true;
            player.enabled = false;
            player.playerMoveSpeed = 0;
            player.GetComponent<SpriteRenderer>().enabled = false;

            {
                pauseText.text = "PAUSED";
                ButtonHandler();
            }

            foreach (Arrow tile in arrows)
            {
                tile.enabled = false;
                tile.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
        else
        {
            gameIsPaused = false;

            //pauseCanvas.enabled = false;
            player.enabled = true;
            player.playerMoveSpeed = playerMoveSpeed;
            player.GetComponent<SpriteRenderer>().enabled = true;
            pauseText.text = "";
            foreach (Arrow tile in arrows)
            {
                tile.enabled = true;
                tile.GetComponent<SpriteRenderer>().enabled = true;
            }
            
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
