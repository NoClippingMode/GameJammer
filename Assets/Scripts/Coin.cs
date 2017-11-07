using Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    public int coinValue = 1;
    public bool taken = false;

    // if the player touches the coin, it has not already been taken, and the player can move (not dead or victory)
    // then take the coin
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "Player") && (!taken) && (other.gameObject.GetComponent<PlatformerCharacter2D>().playerCanMove))
        {
            // mark as taken so doesn't get taken multiple times
            taken = true;
            
            // do the player collect coin thing
            other.gameObject.GetComponent<PlatformerCharacter2D>().CollectCoin(coinValue);

            // destroy the coin
            DestroyObject(this.gameObject);
        }
    }
}
