using UnityEngine;
//using UnityEngine.UI;
using System.Collections;

public class MonsterStealth : MonoBehaviour
{
    public const int startingStealth = 100;                            // The amount of stealth the player starts the game with.
    public int currentStealth = startingStealth;                                   // The current stealth the player has.

    bool? isCaught = null;                                              // Whether the player is caught.
    bool? damaged = null;                                               // True when the player gets damaged/makes noise.

    public void StealthDown(int amount)
    {
        damaged = true;  //this will need a timeout to set back to null

        // Reduce the current stealth by the damage amount.
        currentStealth -= amount;

        if(currentStealth <= 0 /*&& !isCaught*/)
        {
            currentStealth = 0;
            // ... it should die.
            isCaught = true;
        }
    }

}
