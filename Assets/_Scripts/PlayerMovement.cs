using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7.5f;
    public FlipperButton flipperButton;

    // Update is called once per frame
    void Update()
    {
        // Check if the flipper button is not pressed
        if (!flipperButton.IsFlipperActivated())
        {
            // Check for touch input
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                // Check if the touch is on the left half of the screen
                if (touch.position.x < Screen.width / 2)
                {
                    MoveLeft();
                }
                // Check if the touch is on the right half of the screen
                else
                {
                    MoveRight();
                }
            }
        }
    }

    public void MoveLeft()
    {
        // Move the player to the left
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    public void MoveRight()
    {
        // Move the player to the right
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}
