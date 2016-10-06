using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

    Player player;

	// Use this for initialization
	void Start () {
        //  Get the player information
        player = GameObject.FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D() {
        switch (tag)
        {
            case "DownArrow":
                player.playerDirection = Player.Direction.DOWN;
                break;
            case "UpArrow":
                player.playerDirection = Player.Direction.UP;
                break;
            case "LeftArrow":
                player.playerDirection = Player.Direction.LEFT;
                break;
            case "RightArrow":
                player.playerDirection = Player.Direction.RIGHT;
                break;
        }
    }
}
