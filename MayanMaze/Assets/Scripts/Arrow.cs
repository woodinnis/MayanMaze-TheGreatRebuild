using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

    public float xBoundaryLower;
    public float xBoundaryUpper;
    public float yBoundaryLower;
    public float yBoundaryUpper;

    private Player player;
    private Camera myCamera;
    private Collider2D arrowCollider;
    private Vector2 previousMousePosition;

    private float moveSpeed = 0.8f;
    public float recenterAt = 0.1f;
    private bool playerIsApproaching = true;
    private bool activeArrowTile = false;

    // Use this for initialization
    void Start()
    {
        //  Get the player information
        player = GameObject.FindObjectOfType<Player>();
        myCamera = GameObject.FindObjectOfType<Camera>();
        //boundary = GameObject.FindGameObjectsWithTag("MazeBoundary");

        arrowCollider = GetComponent<Collider2D>();
    }

    //  Change player direction when they collide with an arrow
    void OnTriggerEnter2D(Collider2D collider)
    {
        //  The section of code working on smoothing movement onto an arrow tile has been extracted and the call commented out
        //  It can be reintegrated in some fashion later in development
        //  This action has been moved to Player.cs
        //  The transtion code will remain here until it's reintegrated.
        //  PlayerTrasitionSmoothing();

        verifyAndResetTilePosition(collider);
    }

    private void verifyAndResetTilePosition(Collider2D collider)
    {
        //  This vector is used to return tiles (currently only arrows) to their positions without conflict
        Vector2 colliderReturnPosition;

        if (!activeArrowTile)
            colliderReturnPosition = transform.position;
        else
            colliderReturnPosition = previousMousePosition;

        //  If player drops an arrow on top of an occupied tile, return the arrow to its previous position
        switch (collider.tag)
        {
            case "Wall":
            case "Door":
            case "Hole":
                {
                    transform.position = previousMousePosition;
                    break;
                }
            case "UpArrow":
            case "DownArrow":
            case "LeftArrow":
            case "RightArrow":
                {
                    if (activeArrowTile)
                    {
                        transform.position = previousMousePosition;
                        collider.enabled = false;   //  Disable the arrow while it returns to its previous position
                    }
                    else
                        transform.position = colliderReturnPosition;
                    break;
                }
            default:
                {
                    break;
                }
        }
        collider.enabled = true;    //  Reenable the arrow
    }

    void OnTrigger2DExit()
    {
        activeArrowTile = false;
    }

    //  The code which was tested to smooth player transtition onto an arrow tile
    private void PlayerTrasitionSmoothing()
    {
        Vector2 fast = Vector2.zero;

        //  This seems to work just fine
        player.transform.position = Vector2.SmoothDamp(player.transform.position, transform.position, ref fast, moveSpeed);

        print("Player before: " + player.transform.position);
        print("Arrow before: " + this.transform.position);

        //  Check player proximity to arrow tile x,y center and recenter when close
        //  So far this hasn't been tuned in any way that works functionally with changing direction
        if (player.transform.position.x <= (transform.position.x - recenterAt) ||
            player.transform.position.y <= (transform.position.y - recenterAt))
            player.transform.position = transform.position;

        if (player.transform.position.x >= (transform.position.x + recenterAt) ||
            player.transform.position.y >= (transform.position.y + recenterAt))
            player.transform.position = transform.position;


        print("Player after: " + player.transform.position);
        print("Arrow after: " + transform.position);


        /*
        if (collider.tag == "Player")
        {
            playerIsApproaching = false;

            print(playerIsApproaching);

            //  Create assign the value of the player's movement speed
            if (player.playerDirection == Player.Direction.DOWN || player.playerDirection == Player.Direction.UP)
                moveSpeed = player.transform.position.normalized.y;
            if (player.playerDirection == Player.Direction.LEFT || player.playerDirection == Player.Direction.RIGHT)
                moveSpeed = player.transform.position.normalized.x;
        }

        */
    }

    //  Executed on the click of a mouse button
    void OnMouseDown()
    {
        //  Set this as the active arrow tile
        activeArrowTile = true;

        //  Obtain the position of the mouse upon clicking the mouse.
        Vector2 clickHere = CalculateWorldPointOfMouseClick();
        previousMousePosition = SnapToGrid(clickHere);
    }

    //  Movement of Arrows
    void OnMouseDrag() {

        //  This is probably not the most efficient way of handling this, but it will work for now
        //  if ((transform.position. < BoundryLower && transform.position > BoundryUpper))

        //  Disable the arrow's collider while it is being moved
        arrowCollider.enabled = false;
        
        //  Move the arrow around the gamespace by clicking and dragging
        Vector2 rawPos = CalculateWorldPointOfMouseClick();
        if ((rawPos.x > xBoundaryLower && rawPos.x < xBoundaryUpper) &&
                (rawPos.y > yBoundaryLower && rawPos.y < yBoundaryUpper))
            transform.position = SnapToGrid(rawPos);
    }

    void OnMouseUp()
    {
        //  Reenable the arrow's collider once it has been placed
        arrowCollider.enabled = true;
    }

    Vector2 CalculateWorldPointOfMouseClick()
    {
        //  Calculate the worldspace of the mouse (instead of the default pixels used by Input.mousePosition)
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);

        return worldPos;
    }

    Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        //  Snap tiles to the gamespace grid
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }
}
