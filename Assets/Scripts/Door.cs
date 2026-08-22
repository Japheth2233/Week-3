using UnityEngine;

public class Door : MonoBehaviour
{
    public bool doorUnlocked;
    bool playerInRange;
    PlayerMovement player;

    //Door changes scenes!
    //Door changes locations！
    //Door just opens and allows you to pass through!

    void Update()
    {
        if (playerInRange) //Is the player nearby？CHECK
        {
            if (player.playerInteracting) //Did the player press E? CHECK
            {
                if (doorUnlocked) //Is the door unlocked? [KEY]
                {
                    Debug.Log("Door is unlocked, you can go through!");
                }
            }
        }
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player = collision.GetComponent<PlayerMovement>();
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

}








