using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float tougeAmount = 800f;
    [SerializeField] float baseSpeed = 12f;
    [SerializeField] float boostSpeed = 25f;

    Rigidbody2D rb2d;
    SurfaceEffector2D[] surfacesEffector2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfacesEffector2d = FindObjectsOfType<SurfaceEffector2D>();
    }
    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }
    void RotatePlayer()
    {
        float steerAmount = Input.GetAxis("Horizontal") * tougeAmount * Time.deltaTime;
        rb2d.AddTorque(-steerAmount);
    }
    void RespondToBoost()
    {
        foreach (var surface in surfacesEffector2d)
        {
            if (Input.GetAxis("Jump") == 0)
            {
                surface.speed = baseSpeed;
            }
            else
            {
                surface.speed = boostSpeed;
            }
        }
    }
}
