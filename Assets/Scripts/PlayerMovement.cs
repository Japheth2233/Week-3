using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public int playerMoney;

    //Take in WASD input
    public Vector2 movementInput; //WASD = W (0, 1), A (-1, 0)
    
    //Use that to the player in that direction
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    public float moveSpeed = 5;
    public float jumpHeight = 10;

    //Take in SPACE input
    //Apply force upwards.
    //Only be able to jump if touching the ground.

    public bool isGrounded; //Am I touching the ground?
    public LayerMask groundLayer; //What is the ground?

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //The code that assigns our rigidbody.
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movementInput.x * moveSpeed, rb.linearVelocity.y); //Move the player - SIDE.
        FlipSprite();

        Debug.DrawRay(transform.position, Vector2.down * 1, Color.blue); //Draws the line.
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1, groundLayer); 

        //rb.linearVelocity = new Vector2(movementInput.x * moveSpeed, movementInput.y * moveSpeed); //Move the player - TOP DOWN.
    }

    void FlipSprite()
    {        
        //If I am moving right, I dont want the sprite to be flipped.
        if (movementInput.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movementInput.x < 0) //If I am moving left, I want the sprite to be flipped.
        {
            spriteRenderer.flipX = true;
        }
        //If it's just nothing, keep as is.
    }

    //FUNCTION TO CONNECT OUR ACTIONS.
    public void Move(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>(); //this gets the input
    }

    public bool playerInteracting; //Is my key being pressed?
    public void Interact(InputAction.CallbackContext context)
    {
        if (context.started) //Is E pressed?
        {
            playerInteracting = true;
        }
        else if (context.canceled) //Have I let go?
        {
            playerInteracting = false;
        }
    }



    public void Jump(InputAction.CallbackContext context)
    {
        if (isGrounded == true) //ONLY IF WE ARE CURRENTLY TOUCHING THE GROUND, WE CAN JUMP
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpHeight);//Applies velocity UP!
        }
    }




}
