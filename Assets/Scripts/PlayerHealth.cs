using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    Vector3 startPosition; //Where our player has started the game.
    public Transform recentCheckpoint;

    private void Start()
    {
        startPosition = transform.position; //Set that variable to our position
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Die(); //Die!!!
        }

        if (collision.CompareTag("Checkpoint"))
        {
            recentCheckpoint = collision.gameObject.transform;//Save the position of the checkpoint.
            collision.gameObject.GetComponent<Animator>().Play("hit"); //animate the checkpoint!!!
        }
    }

    public void Die()
    {
        if (recentCheckpoint == null) //If we have not hit a checkpoint!
        {
            transform.position = startPosition; //Put the player back to the start position.
        }
        else
        {
            transform.position = recentCheckpoint.position; //Put the player at the checkpoint position.
        }
        
    }
}
