using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
namespace Character
{
    public enum DirectionType
    {
        Incline,
        Decline
    }

    public class Ramp : MonoBehaviour {

        public float slope = 0.0f;
        public DirectionType direction;


        // if the player touches the coin, it has not already been taken, and the player can move (not dead or victory)
        void OnTriggerEnter2D(Collider2D other)
        {
            if ((other.tag == "Player") && (other.gameObject.GetComponent<PlatformerCharacter2D>().playerCanMove))
            {
                other.gameObject.GetComponent<PlatformerCharacter2D>().ApplySlopeForce(direction, slope);
            }
        }
    }

}
