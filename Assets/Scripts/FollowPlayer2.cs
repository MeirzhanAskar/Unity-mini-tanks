using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    Player2Control check;
    SpriteRenderer render;
    void Start()
    {
        check = player.GetComponent<Player2Control>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        try
        {
            if (check.shield)
            {
                render.enabled = true;
            }
            else
            {
                render.enabled = false;
            }
            transform.position = player.transform.position;
        }
        catch { Destroy(gameObject); }
    }
}
