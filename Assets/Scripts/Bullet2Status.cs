using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2Status : MonoBehaviour
{
    public GameObject player;

    // Declare the variable
    SpriteRenderer spriteRenderer;

    void Start()
    {
        // ASSIGN the variable (very important)
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        try
        {
            if (player.GetComponent<Player2Control>().cooldown)
            {
                // use the variable
                spriteRenderer.enabled = true;
            }
            else
            {
                spriteRenderer.enabled = false;
            }
        }
        catch { Destroy(gameObject); }
    }
}
