using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int value; //How much am I worth?

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //Need to go into our game, and tag our player
        {
            //Add our value to the player.
            collision.GetComponent<PlayerMovement>().playerMoney += value;
            
            //Delete the coin.
            Destroy(gameObject);

        }
    }


}
