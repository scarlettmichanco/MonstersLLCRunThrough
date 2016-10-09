// modified from unity tutorial on health meter
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MonsterStealth : MonoBehaviour
{
    public int startingStealth = 100;                            // The amount of stealth the player starts the game with.
    public int currentStealth;                                   // The current stealth the player has.
    public Slider stealthSlider;                                 // Reference to the UI's stealth bar.
    public Image damageImage;                                   // Reference to an image to flash on the screen on making too much noise.
    public AudioClip deathClip;                                 // The audio clip to play when the player gets caught.
    public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.


    Animator anim;                                              // Reference to the Animator component.
    AudioSource playerAudio;                                    // Reference to the AudioSource component.
    PlayerMovement playerMovement;                              // Reference to the player's movement.
    bool isCaught;                                              // Whether the player is caught.
    bool damaged;                                               // True when the player gets damaged/makes noise.


    void Awake ()
    {
        // Setting up the references.
        anim = GetComponent <Animator> ();
        playerAudio = GetComponent <AudioSource> ();
        playerMovement = GetComponent <PlayerMovement> ();

        // Set the initial stealth of the player.
        currentStealth = startingStealth;
    }


    void Update ()
    {
        // If the player has just been damaged...
        if(damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        // Reset the damaged flag.
        damaged = false;
    }


    public void TakeDamage (int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;

        // Reduce the current stealth by the damage amount.
        currentStealth -= amount;

        // Set the stealth bar's value to the current.
        stealthSlider.value = currentStealth;

        // If the player has no more stealth and hasn't yet been caught
        if(currentStealth <= 0 && !isCaught)
        {
            // ... it should die.
            Caught ();
        }
    }


    void Caught ()
    {
        // Set the caught flag so this function won't be called again.
        isCaught = true;

        // Tell the animator that the player is dead.
        anim.SetTrigger ("Caught");

        // Set the audiosource to play the capture clip and play it.
        playerAudio.clip = deathClip;
        playerAudio.Play ();

        // Turn off the movement and shooting scripts.
        playerMovement.enabled = false;
    }
}
