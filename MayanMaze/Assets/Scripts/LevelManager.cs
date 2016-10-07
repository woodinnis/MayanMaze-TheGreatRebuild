using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    void Start() {
        
        //Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }
	public void LoadLevel(string name){
        SceneManager.LoadScene(name);
	}
	
	public void QuitRequest(){
		Application.Quit();
	}
	
	public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //  Restart a level
    public void RestartLevel()
    {
        //  Get currently loaded scene;
        //Scene scene = SceneManager.GetActiveScene();

        //print(scene.ToString());
        //  Unload the scene
        //SceneManager.UnloadScene(scene);

        //  Reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
