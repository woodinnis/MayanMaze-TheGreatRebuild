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
            if (scene.enabled)
            {
                Levels.Add(scene.path.ToString());
            }
        }

        Invoke("LoadStartMenu", autoLoadNextLevelAfter);
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(startScene);
    }

    /// <summary>
    /// All functions in the GetCurrentFunctions region are used to obtain and return current level information
    /// </summary>
    /// <returns></returns>
    #region GetCurrentFunctions

    public int GetCurrentLevelIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public string GetCurrentLevelName()
    {
        string currentLevelName = SceneManager.GetActiveScene().name;

        return currentLevelName;
    }

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

    int GetNextLevelIndex()
    {
        int currentLevelIndex = GetCurrentLevelNumber();
        int nextLevelIndex = 0;

        if (currentLevelIndex + 1 < Levels.Capacity)
            nextLevelIndex = currentLevelIndex + 1;

        return nextLevelIndex;
        //Debug.Log("Current Level Index: " + currentLevelIndex);

        //for (int i = currentLevelIndex; i < levelList.Length; i++)
        //{
        //    //Debug.Log(levelList[i]);

        //    // This section correctly loads the names of the next levelList entry but still isn't checking if the name is valid in the build settings
        //    if (SceneManager.GetSceneByName(levelList[i]).IsValid())
        //    {
        //        nextLevelIndex = i + 1;
        //        //Debug.Log("Next Valid Scene " + levelList[nextLevelIndex] + " at index " + nextLevelIndex);
        //        break;
        //    }
        //    else
        //    {
        //       // Debug.Log("No Valid Scene at index " + i);
        //    }
        //}
    }

    #endregion

    public void LoadNextLevel(){

        if (GetCurrentLevelName() != finalScene)
        {
            int nLevel = GetNextLevelIndex();

            // I'd like to find a more efficient way to clean up the strings. Preferably when they get loaded into the list.
            string nextScene = Levels[nLevel];
            nextScene = nextScene.Replace(".unity", "");
            nextScene = nextScene.Replace("Assets/", "");
            SceneManager.LoadScene(nextScene);
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
