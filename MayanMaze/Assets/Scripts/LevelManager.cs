using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;
    public string startScene;
    public string finalScene;
    public string[] levelList;

    [SerializeField]
    int nextSceneBuildIndex;
    [SerializeField]
    int finalSceneBuildIndex;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        
        Invoke("LoadStartMenu", autoLoadNextLevelAfter);
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(startScene);
    }

    public int GetCurrentLevelIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public string GetCurrentLevelName()
    {
        return SceneManager.GetActiveScene().name;
    }

    // Returns the LevelList array index of the currently loaded level
    // Checks the Level Name against all entries in the LevelList using a for loop and returns the valid array index
    public int GetCurrentLevelNumber()
    {
        string currentLevelName = GetCurrentLevelName();
        int currentLevelIndex = 0;

        for(int i = 0; i < levelList.Length; i++)
        {
            if (levelList[i] == currentLevelName)
                currentLevelIndex = i;
        }
        
        return currentLevelIndex;
    }

    // Load the next level in the Level List array, 
    // Checks the currently loaded level against finalScene and loads the next LevelList entry until the check returns true
	public void LoadNextLevel(){

        if (GetCurrentLevelName() != finalScene)
        {
            SceneManager.LoadScene(GetCurrentLevelNumber() + 1);
        }
        else
            LoadStartMenu();
    }

    //  Get the active scene and reload it
    //  Should probably see if there's a way to do this with ASYNC for optimization at some point
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
