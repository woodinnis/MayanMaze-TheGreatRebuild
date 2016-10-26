using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

    private Player player;
    private Transform transform;
    private Camera myCamera;

    private float moveSpeed = 0.8f;
    public float recenterAt = 0.1f;
    private bool playerIsApproaching = true;

    // Use this for initialization
    void Start () {
        //  Get the player information
        player = GameObject.FindObjectOfType<Player>();
        myCamera = GameObject.FindObjectOfType<Camera>();

        transform = GetComponent<Transform>();
	}

    //  Change player direction when they collide with an arrow
    void OnTriggerEnter2D(Collider2D collider)
    {
        //  The section of code working on smoothing movement onto an arrow tile has been extracted and the call commented out
        //  It can be reintegrated in some fashion later in development
        //  PlayerTrasitionSmoothing();

        //  Snap the player to the position.x/y of the arrow tile
        player.transform.position = transform.position;

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

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            playerIsApproaching = true;
            
    }

    //  Movement of Arrows

    void OnMouseDrag() {
        //  Move the arrow around the gamespace by clicking and dragging
        Vector2 rawPos = CalculateWorldPointOfMouseClick();
        transform.position = SnapToGrid(rawPos);
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
