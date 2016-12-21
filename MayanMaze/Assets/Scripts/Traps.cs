using UnityEngine;
using System.Collections;

public class Traps : MonoBehaviour {

    private Player player;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {

        levelManager = FindObjectOfType<LevelManager>();
        player = FindObjectOfType<Player>();
	}

    //  Reset level when player collides with the trap
    public void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if (otherCollider.collider.tag == "Player")
        {
            player.transform.position = transform.position;
            Debug.Log("Ouch!");
            levelManager.RestartLevel();
        }
    }

    //  Reset level when player collides with the hole
    void OnTriggerEnter2D(Collider2D collider)
    {
        //  Snap player to the position of the hole
        if (collider.tag == "Player")
        {
            player.transform.position = transform.position;

            //  Reload the level
            levelManager.RestartLevel();
        }
    }
}
