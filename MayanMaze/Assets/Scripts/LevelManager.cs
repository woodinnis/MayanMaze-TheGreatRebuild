using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;
    public string startScene;
    public string finalScene;
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
                // Trim the Assets folder, and .unity extentions from the strings
                string st = scene.path.ToString().Replace("Assets/", "");
                st = st.Replace(".unity", "");

                Levels.Add(st);
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

    #endregion

    #region NextLevelFunctions

    /// <summary>
    /// If incrementing the currentLevelIndex by 1 does not go beyond the Levels list capacity 
    /// assign nextLevelIndex the value of currentLevelIndex + 1
    /// </summary>
    /// <returns>nextLevelIndex</returns>
    int GetNextLevelIndex()
    {
        int currentLevelIndex = GetCurrentLevelNumber();
        int nextLevelIndex = 0;

        if (currentLevelIndex + 1 < Levels.Capacity)
            nextLevelIndex = currentLevelIndex + 1;

        return nextLevelIndex;
    }

    /// <summary>
    /// If the value returned by GetCurrentLevelName() does not match finalScene, procede to the next level, 
    /// otherwise return to the main menu
    /// </summary>
    public void LoadNextLevel(){

        if (GetCurrentLevelName() != finalScene)
        {
            int nLevel = GetNextLevelIndex();

            string nextScene = Levels[nLevel];
            SceneManager.LoadScene(nextScene);
        }
        else
            LoadStartMenu();
    }

    #endregion

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
 
}
