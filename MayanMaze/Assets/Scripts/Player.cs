using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum Direction { UP, DOWN, LEFT, RIGHT };

    public float playerMoveSpeed;
    public Direction playerDirection;

    private Transform transform;
    private bool isMovingTowards = true;

    // Use this for initialization
    void Start () {
        transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //  Move player based on playerDirection
        switch (playerDirection)
        {
            case Direction.DOWN:
                transform.position += Vector3.down * playerMoveSpeed * Time.deltaTime;
                break;
            case Direction.UP:
                transform.position += Vector3.up * playerMoveSpeed * Time.deltaTime;
                break;
            case Direction.LEFT:
                transform.position += Vector3.left * playerMoveSpeed * Time.deltaTime;
                break;
            case Direction.RIGHT:
                transform.position += Vector3.right * playerMoveSpeed * Time.deltaTime;
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //  Check player is moving towards a wall
        if (isMovingTowards)
        {
            //  Change player movement state
            isMovingTowards = false;
            //  Change player direction
            ChangePlayerDirection();
        }
    }

    private void ChangePlayerDirection()
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

    void OnCollisionExit2D()
    {
        if (!isMovingTowards)
        {
            isMovingTowards = true;
        }
    }
}
