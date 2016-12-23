using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum Direction { UP, DOWN, LEFT, RIGHT };

    public float moveSpeed;
    public Direction playerDirection;

    public Sprite upWalkGraphic;
    public Sprite downWalkGraphic;
    public Sprite leftWalkGraphic;
    public Sprite rightWalkGraphic;

    [HideInInspector]
    public float playerMoveSpeed;

    private SpriteRenderer playerSpriteRenderer;
    private bool isMovingTowards = true;

    private LevelManager levelManager;
    private CountdownTimer Player_CountdownTimer;

    // Use this for initialization
    void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        playerSpriteRenderer = GetComponent<SpriteRenderer>();

        ChangePlayerDirection(playerDirection);
        Player_CountdownTimer = FindObjectOfType<CountdownTimer>();

        print(Player_CountdownTimer.name);

        //  Player begins the level standing still
        playerMoveSpeed = 0f;
    }

    void Update()
    {
        //  When the countdown finishes player starts moving
        if(Player_CountdownTimer.countdownTarget <= 0f)
        {
            playerMoveSpeed = moveSpeed;
        }
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
        Vector2 newPlayerPosition = collider.transform.position;
        transform.position = newPlayerPosition;     //  This needs to be smoothed out during polish. But it works for now

        switch (collider.tag)
        {
            //  Load the next level
            case "Door":
                levelManager.LoadNextLevel();
                break;
            //  Adjust player direction
            case "DownArrow":
                ChangePlayerDirection(Direction.DOWN);
                break;
            case "UpArrow":
                ChangePlayerDirection(Direction.UP);
                break;
            case "LeftArrow":
                ChangePlayerDirection(Direction.LEFT);
                break;
            case "RightArrow":
                ChangePlayerDirection(Direction.RIGHT);
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            //  Check player is moving towards a wall
            if (isMovingTowards)
            {
                //  change player movement state
                isMovingTowards = false;

                //  Reverse player direction
                ReverseDirection();
            }
        }
    }

    private void ReverseDirection()
    {
        //  Reverse player direction
        switch (playerDirection)
        {
            case Direction.UP:
                ChangePlayerDirection(Direction.DOWN);
                break;
            case Direction.DOWN:
                ChangePlayerDirection(Direction.UP);
                break;
            case Direction.LEFT:
                ChangePlayerDirection(Direction.RIGHT);
                break;
            case Direction.RIGHT:
                ChangePlayerDirection(Direction.LEFT);
                break;
        }
    }

    private void ChangePlayerDirection(Direction thisWay)
    {
        //  Change player direction
        playerDirection = thisWay;

        //  Change player image
        switch (thisWay)
        {
            case Direction.UP:
                {
                    playerSpriteRenderer.sprite = upWalkGraphic;
                    break;
                }
            case Direction.DOWN:
                {
                    playerSpriteRenderer.sprite = downWalkGraphic;
                    break;
                }
            case Direction.LEFT:
                {
                    playerSpriteRenderer.sprite = leftWalkGraphic;
                    break;
                }
            case Direction.RIGHT:
                {
                    playerSpriteRenderer.sprite = rightWalkGraphic;
                    break;
                }
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
