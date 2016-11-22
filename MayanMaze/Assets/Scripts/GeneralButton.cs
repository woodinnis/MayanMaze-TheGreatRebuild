using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GeneralButton : MonoBehaviour {

    public enum ButtonType { MENU, PAUSE, RESTART, CONTINUE };

    public ButtonType buttonType;

    private Button button;
    private Canvas tutorialCanvas;
    private GameObject tutorialPanel;
    //private PauseScreen pauseScreen;

    // Use this for initialization
    void Start() {
        
        button = GetComponent<Button>();

        //tutorialCanvas = GetComponentInParent<Canvas>();
        //tutorialPanel = GameObject.Find("Tutorial Panel");
        //pauseScreen = FindObjectOfType<PauseScreen>();

        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //  Perform the selected button operation
        switch (buttonType)
        {
            case ButtonType.MENU:
                {
                    LevelManager levelManager = FindObjectOfType<LevelManager>();
                    levelManager.GoToStart();
                    print("Menu");
                    break;
                }
            case ButtonType.PAUSE:
                {
                    PauseScreen pauseScreen = FindObjectOfType<PauseScreen>();
                    pauseScreen.PauseFunction();
                    print("Pause");
                    break;
                }
            case ButtonType.RESTART:
                {
                    LevelManager levelManager = FindObjectOfType<LevelManager>();
                    levelManager.RestartLevel();
                    print("Restart");
                    break;
                }
            case ButtonType.CONTINUE:
                {
                    print("Continue");
                    break;
                }
        }
        //tutorialCanvas.enabled = false;
        //pauseScreen.PauseFunction();
    }

}
