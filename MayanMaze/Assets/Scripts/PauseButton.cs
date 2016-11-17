using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseButton : MonoBehaviour {

    private Button button;
    private PauseScreen pauseScreen;

    // Use this for initialization
    void Start()
    {

        button = GetComponent<Button>();
        pauseScreen = GetComponentInParent<PauseScreen>();

        button.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        pauseScreen.PauseFunction();
    }
}
