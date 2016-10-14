using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;
    public Object startScene;
    public Object finalScene;

    void Awake()
    {
        DontDestroyOnLoad(this.transform);
    }

    void Start() {
        
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    //  This event is being deprecated
    void OnLevelWasLoaded()
    {
        if(SceneManager.GetActiveScene().name == finalScene.name)
        {
            Invoke("GoToStart", autoLoadNextLevelAfter);
        }
    }

	public void LoadLevel(string name){
        SceneManager.LoadScene(name);
	}
	
	public void QuitRequest(){
		Application.Quit();
	}
	
    public string GetCurrentLevel()
    {
        return SceneManager.GetActiveScene().name;
    }

	public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //  Restart a level
    public void RestartLevel()
    {
        //  Reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    //  Return to the Start menu
    public void GoToStart()
    {
        SceneManager.LoadScene(startScene.name);
    }
}
