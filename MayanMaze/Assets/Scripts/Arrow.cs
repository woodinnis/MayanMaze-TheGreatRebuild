using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

    private Player player;
    private Transform transform;
    private Camera myCamera;

    // Use this for initialization
    void Start () {
        //  Get the player information
        player = GameObject.FindObjectOfType<Player>();
        myCamera = GameObject.FindObjectOfType<Camera>();

        transform = GetComponent<Transform>();
	}

    //  Change player direction when they collide with an arrow
    void OnTriggerEnter2D(Collider2D collider) {

        //  Create a new Vector2 and assign the value of the player's movement speed
        //  This was an attempt to utilize Vector2.SmoothDamp() to smooth out the player movement on to an arrow tile.
        //Vector2 moveSpeed = new Vector2(0, 0);
        //if (player.playerDirection == Player.Direction.DOWN || player.playerDirection == Player.Direction.UP)
        //    moveSpeed = new Vector2(0.0f, player.playerMoveSpeed);
        //if (player.playerDirection == Player.Direction.LEFT || player.playerDirection == Player.Direction.RIGHT)
        //    moveSpeed = new Vector2(player.playerMoveSpeed, 0.0f);

        //  Using Vector2.Lerp looks more promising, but has been unsuccessful so far. Converting a Vector2 to a float is the current hurdle
        //player.transform.position = Vector2.Lerp(player.transform.position, transform.position, player.transform.position);


        print("Player Norm: " + player.transform.position.normalized);

        //  Reset player position to match the Arrow tile.
        player.transform.position = transform.position;     //  This needs to be smoothed out during polish. But it works for now

        print("Player: " + player.transform.position);
        print("Player Norm: " + player.transform.position.normalized);
        print("Arrow: " + transform.position);


        //  Check arrow tag and change player direction accordingly
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
