using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum Direction { UP, DOWN, LEFT, RIGHT };

    public float playerMoveSpeed;
    public Direction playerDirection;

    private Transform transform;
    private float realMoveSpeed;
 
    // Use this for initialization
    void Start () {
        transform = GetComponent<Transform>();
        realMoveSpeed = playerMoveSpeed / 100;
	}
	
	// Update is called once per frame
	void Update () {
        
        //  Move player based on playerDirection
        switch (playerDirection)
        {
            case Direction.DOWN:
                transform.position += Vector3.down * realMoveSpeed;
                break;
            case Direction.UP:
                transform.position += Vector3.up * realMoveSpeed;
                break;
            case Direction.LEFT:
                transform.position += Vector3.left * realMoveSpeed;
                break;
            case Direction.RIGHT:
                transform.position += Vector3.right * realMoveSpeed;
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        switch (playerDirection)
        {
            case Direction.DOWN:
                playerDirection = Direction.UP;
                break;
            case Direction.UP:
                playerDirection = Direction.DOWN;
                break;
            case Direction.LEFT:
                playerDirection = Direction.RIGHT;
                break;
            case Direction.RIGHT:
                playerDirection = Direction.LEFT;
                break;
        }
    }

    void OnCollisionStay2D()
    {
        float resetPosition = 1;
        switch (playerDirection)
        {
            case Direction.DOWN:
                print("Stuck Moving " + playerDirection.ToString());
                break;
            case Direction.UP:
                print("Stuck Moving " + playerDirection.ToString());
                break;
            case Direction.LEFT:
                print("Stuck Moving " + playerDirection.ToString());
                break;
            case Direction.RIGHT:
                print("Stuck Moving " + playerDirection.ToString());
                break;
        }
    }

    // TODO: Create playerChangeDirection() to centralize direction changes
}
