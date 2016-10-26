using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    //public LevelManager levelManager;

    private Player player;
    private Transform transform;
    

    // Use this for initialization
    void Start () {
        player = GameObject.FindObjectOfType<Player>();
        transform = GetComponent<Transform>();
        //  levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
}
