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

    void OnTriggerEnter2D() {
        //  Change player direction based on the type of (tag) arrow
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
