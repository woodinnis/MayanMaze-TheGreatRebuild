using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Hole : MonoBehaviour {

    private Player player;
    private Transform transform;
    private LevelManager levelManager;

    private Scene scene;

    // Use this for initialization
    void Start () {
        player = GameObject.FindObjectOfType<Player>();
        transform = GetComponent<Transform>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
    //  Reset level when player collides with the hole
	void OnTriggerEnter2D(Collider2D collider) {
        //  Snap player to the position of the hole
        if (collider.tag == "Player")
        {
            player.transform.position = transform.position;

            //  Reload the level
            levelManager.RestartLevel();
        }
    }
}
