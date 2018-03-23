using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;
    public string startScene;
    public string finalScene;
    public string[] levelList;
    public List<string> Levels = new List<string>();

    [SerializeField]
    int nextSceneBuildIndex;
    [SerializeField]
    int finalSceneBuildIndex;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    void Start() {

        // Load up the Levels List with all enabled scenes.
        foreach(EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if(scene.enabled)
                Levels.Add(scene.path.ToString());
        }

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

    int GetNextLevelIndex()
    {

        int nextLevelIndex = 0;
        int currentLevelIndex = GetCurrentLevelNumber();

//        Debug.Log("Current Level Index: " + currentLevelIndex);

        for (int i = currentLevelIndex; i < levelList.Length; i++)
        {
            //Debug.Log(levelList[i]);
            
            // This section correctly loads the names of the next levelList entry but still isn't checking if the name is valid in the build settings
            if (SceneManager.GetSceneByName(levelList[i]).IsValid())
            {
                nextLevelIndex = i + 1;
                //Debug.Log("Next Valid Scene " + levelList[nextLevelIndex] + " at index " + nextLevelIndex);
                break;
            }
            else
            {
               // Debug.Log("No Valid Scene at index " + i);
            }
        }

        //if (currentLevelName != levelList[currentBuildIndex])
        //{
        //    Debug.Log("Invalid Level " + currentLevelName + " at Index " + currentBuildIndex);
        //    for (int i = currentBuildIndex; i < levelList.Length; i++)
        //    {
        //        if (levelList[i] == currentLevelName)
        //        {
        //            currentBuildIndex = i;
        //            Debug.Log("Level Index Corrected");
        //        }
        //    }
        //}
        //else
        //    Debug.Log("Current Level " + currentLevelName + " at Index " + currentBuildIndex);

        return nextLevelIndex;
    }

    public string GetCurrentLevelName()
    {
        string currentLevelName = SceneManager.GetActiveScene().name;

        return currentLevelName;
    }

    // Returns the LevelList array index of the currently loaded level
    // Checks the Level Name against all entries in the LevelList using a for loop and returns the valid array index
    public int GetCurrentLevelNumber()
    {
        string currentLevelName = GetCurrentLevelName();
        int currentLevelIndex = 0;

        // Verify index of current level in the Levels list
        foreach (string level in Levels)
        {
            if (level.Contains(currentLevelName))
            {
                currentLevelIndex = Levels.IndexOf(level);
            }
        }
        return currentLevelIndex;
    }

    // Load the next level in the Level List array, 
    // Checks the currently loaded level against finalScene and loads the next LevelList entry until the check returns true
    //
    // An exception is required for levels included in the LevelList, but not in the Build.
    // SceneManager.LoadScene() uses Build Index or Scene Names
	public void LoadNextLevel(){

        if (GetCurrentLevelName() != finalScene)
        {
            int nLevel = GetNextLevelIndex();

            SceneManager.LoadScene(levelList[nLevel]);//GetCurrentLevelNumber() + 1);
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
