using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        //if hit the other player, it will destroy the player with itself
        if (other.gameObject.CompareTag("Player2"))
        {
            Destroy(gameObject);
        }
    }
}
