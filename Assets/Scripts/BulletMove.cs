using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //If hit the wall, it will destroy itself
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        //If hit the box, it will destroy box with itself
        if (other.gameObject.CompareTag("Box"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
