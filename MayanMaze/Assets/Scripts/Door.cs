using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    private Player player;
    private Transform transform;
    private LevelManager levelManager;

    // Use this for initialization
    void Start () {
        player = GameObject.FindObjectOfType<Player>();
        transform = GetComponent<Transform>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D()
    {
        print("DOOR!");
        //  Reset player position to match the Arrow tile.
        player.transform.position = transform.position;     //  This needs to be smoothed out during polish. But it works for now

        //  Load the next level
        levelManager.LoadNextLevel();
    }
}
