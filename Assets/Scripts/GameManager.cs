using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager gm;

    public int coins = 0;

    // set things up here
    void Awake()
    {
        // setup reference to game manager
        if (gm == null)
            gm = this.GetComponent<GameManager>();
    }

    public void AddPoints(int amount)
    {
        coins = amount;
    }
}
