using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpToggle : MonoBehaviour
{
    public GameObject healthPowerUp;
    public GameObject shieldPowerUp;
    private float mapY;
    private float mapX;
    private int powerUp;
    public bool toggler = true;
    SpriteRenderer render;
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        InvokeRepeating("SpawnPowerUp", 20, 20);
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (toggler)
            {
                toggler = false;
            }
            else
            {
                toggler = true;
            }
        }
        mapY = Random.Range(-4, 4);
        mapX = Random.Range(-9, 9);
        powerUp = Random.Range(1, 3);
        if (toggler)
        {
            render.color = Color.yellow;
        }
        else
        {
            render.color = Color.red;
        }
    }
    void SpawnPowerUp()
    {
        if (toggler)
        {
            if (powerUp == 1)
            {
                Instantiate(healthPowerUp, new Vector2(mapX, mapY), transform.rotation);
            }
            else if (powerUp == 2)
            {
                Instantiate(shieldPowerUp, new Vector2(mapX, mapY), transform.rotation);
            }
        }
    }
}
