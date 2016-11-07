using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class TutorialButton : MonoBehaviour {

    private GameObject tutorialPanel;
    private Button button;
    private Canvas tutorialCanvas;

    // Use this for initialization
    void Start () {
        tutorialPanel = GameObject.Find("Tutorial Panel");
        button = GetComponent<Button>();
        tutorialCanvas = GetComponentInParent<Canvas>();

        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        tutorialCanvas.enabled = false;
    }
}
