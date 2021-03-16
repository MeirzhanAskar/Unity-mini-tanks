using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
{
    public GameObject player;
    Player1Control check;
    SpriteRenderer render;
    void Start()
    {
        check = player.GetComponent<Player1Control>();
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
