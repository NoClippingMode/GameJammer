using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager gm;

    public int coins = 0;
    public int brightness = 0;

    void Awake()
    {
        if (gm == null)
            gm = this.GetComponent<GameManager>();
    }

    public void AddPoints(int amount)
    {
        coins = amount;
    }

    public void AddLight(int amount)
    {
        brightness = amount;
    }
}
