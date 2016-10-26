using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum Direction { UP, DOWN, LEFT, RIGHT };

    public float playerMoveSpeed;
    public Direction playerDirection;

    private Transform transform;
    private bool isMovingTowards = true;

    private LevelManager levelManager;

    // Use this for initialization
    void Start () {
        transform = GetComponent<Transform>();
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //  Move player based on playerDirection

        switch (playerDirection)
        {
            case Direction.DOWN:
                transform.Translate(Vector2.down * playerMoveSpeed * Time.deltaTime, Space.World);
                break;
            case Direction.UP:
                transform.Translate(Vector2.up * playerMoveSpeed * Time.deltaTime, Space.World);
                break;
            case Direction.LEFT:
                transform.Translate(Vector2.left * playerMoveSpeed * Time.deltaTime, Space.World);
                break;
            case Direction.RIGHT:
                transform.Translate(Vector2.right * playerMoveSpeed * Time.deltaTime, Space.World);
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        //  Reset player position to match the Arrow tile.
        transform.position = collider.transform.position;     //  This needs to be smoothed out during polish. But it works for now

        switch (collider.tag)
        {
            //  Load the next level
            case "Door":
                levelManager.LoadNextLevel();
                break;
            //  Adjust player direction
            case "DownArrow":
                playerDirection = Direction.DOWN;
                break;
            case "UpArrow":
                playerDirection = Direction.UP;
                break;
            case "LeftArrow":
                playerDirection = Direction.LEFT;
                break;
            case "RightArrow":
                playerDirection = Direction.RIGHT;
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

    Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        //  Snap tiles to the gamespace grid
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        

        return new Vector2(newX, newY);
    }
}
