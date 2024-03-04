﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed =  5f;

    public float smoothtime = 0.1f;

    float turnsmoothvelocity;

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.GetAxisRaw("Horizontal") ;
       float vertical = Input.GetAxisRaw("Vertical") ;
       Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

       if (direction.magnitude >= 0.1f)
       {
           float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
           float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y,  targetAngle, ref turnsmoothvelocity, smoothtime);
           transform.rotation = Quaternion.Euler(0f, angle, 0f);

           controller.Move(direction * speed * Time.deltaTime);
       }
    }
}
