using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Control : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 75.0f;
    public GameObject bullet;
    public GameObject bulletSpawn;
    public bool cooldown = true;
    public float cooldownTime = 1.5f;
    private float nextFireTime = 0;
    public int Health = 3;
    public GameObject winCheck;
    WinCheck check;
    public bool shield = false;
    private float shieldCooldown = 0;
    public float shieldTime = 5.0f;

    void Start()
    {
        check = winCheck.GetComponent<WinCheck>();
    }
    void Update()
    {
        if (check.GameOver == false)
        {
            //Player Movement
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.right * -speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);
            }
            //Firing the bullet
            if (Time.time > nextFireTime)
            {
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    Instantiate(bullet, bulletSpawn.transform.position, gameObject.transform.rotation);
                    cooldown = false;
                    nextFireTime = Time.time + cooldownTime;
                }
                else
                {
                    cooldown = true;
                }
            }
            //If Health Gets To 0 Destroy The Object
            if (Health == 0)
            {
                Destroy(gameObject);
            }
            //Shield
            if(shield && shieldCooldown<Time.time)
            {
                shield = false;
            }
        }        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet1"))
        {
            if(shield == false)
            {
                Health = Health - 1;
            }            
        }
        if (other.gameObject.CompareTag("Health"))
        {
            if (Health < 3)
            {
                Health++;
            }
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Shield"))
        {
            shield = true;
            shieldCooldown = Time.time + shieldTime;
            Destroy(other.gameObject);
        }
    }
}
