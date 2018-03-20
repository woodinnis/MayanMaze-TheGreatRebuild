using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;
    public string startScene;
    public string finalScene;
    public int buildIndexBuffer;

    [SerializeField]
    int nextSceneBuildIndex;
    [SerializeField]
    int finalSceneBuildIndex;

    void Awake()
    {
        DontDestroyOnLoad(this.transform);
    }

    void Start() {
        
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    //  This event is being deprecated
    //void OnLevelWasLoaded()
    //{
    //    if(SceneManager.GetActiveScene().name == finalScene)
    //    {
    //        Invoke("GoToStart", autoLoadNextLevelAfter);
    //    }
    //}

	public void LoadLevel(string name){
        SceneManager.LoadScene(name);
	}
	
	public void QuitRequest(){
		Application.Quit();
	}

    public int GetCurrentLevelIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public string GetCurrentLevelName()
    {
        return SceneManager.GetActiveScene().name;
    }

    public int GetCurrentLevelNumber()
    {
        return SceneManager.GetActiveScene().buildIndex - buildIndexBuffer;
    }

	public void LoadNextLevel(){

        // Get indices of next and final scenes in build index
        nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        finalSceneBuildIndex = SceneManager.GetSceneByName(finalScene).buildIndex;

        // If index value of next scene is valid, load next scene else return to start
        if (nextSceneBuildIndex < finalSceneBuildIndex)
            SceneManager.LoadScene(nextSceneBuildIndex);//SceneManager.GetActiveScene().buildIndex + 1);
        else
            Invoke("GoToStart", autoLoadNextLevelAfter);
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
        SceneManager.LoadScene(startScene);
    }
}
