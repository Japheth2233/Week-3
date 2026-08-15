using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //Take in WASD input
    public Vector2 movementInput; //WASD = W (1, 0), A (0, 1)
    //Use that to the player in that direction
    Rigidbody2D rb;
    public float moveSpeed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //The code that assigns our rigidbody.
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(movementInput.x * moveSpeed, rb.linearVelocity.y);//Move the player.
    }

    //FUNCTION TO CONNECT OUR ACTIONS.
    public void Move(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>(); //this gets the input
    }






}
