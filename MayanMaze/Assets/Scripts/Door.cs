using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Door : MonoBehaviour {

    private Player player;
    private Transform transform;
    //private int sceneBuildIndex;

    // Use this for initialization
    void Start () {
        player = GameObject.FindObjectOfType<Player>();
        transform = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D()
    {
        print("DOOR!");
        //  Reset player position to match the Arrow tile.
        player.transform.position = transform.position;     //  This needs to be smoothed out during polish. But it works for now
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
