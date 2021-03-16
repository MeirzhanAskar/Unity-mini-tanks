using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearTime : MonoBehaviour
{
    public float disapearTime = 10;
    private float disapearCooldown;
    void Start()
    {
        disapearCooldown = Time.time + disapearTime;
    }
    void Update()
    {
        if (Time.time > disapearCooldown)
        {
            Destroy(gameObject);
        }
    }
}
