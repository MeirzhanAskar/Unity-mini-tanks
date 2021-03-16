using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCheck1 : MonoBehaviour
{
    public GameObject player;
    public GameObject[] health = new GameObject[3];
    Player1Control check;
    SpriteRenderer render1;
    SpriteRenderer render2;
    SpriteRenderer render3;
    void Start()
    {
        check = player.GetComponent<Player1Control>();
        render1 = health[0].GetComponent<SpriteRenderer>();
        render2 = health[1].GetComponent<SpriteRenderer>();
        render3 = health[2].GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        try
        {
            transform.position = player.transform.position;
            if (check.Health > 0)
            {
                render1.enabled = true;
            }
            else
            {
                Destroy(gameObject);
                Destroy(health[0]);
                Destroy(health[1]);
                Destroy(health[2]);
            }
            if (check.Health > 1)
            {
                render2.enabled = true;
            }
            else
            {
                render2.enabled = false;
            }
            if (check.Health > 2)
            {
                render3.enabled = true;
            }
            else
            {
                render3.enabled = false;
            }
        }
        catch { }
    }
}
