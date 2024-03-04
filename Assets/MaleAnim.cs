using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleAnim : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isWalkingBackwards",true);
            anim.SetBool("isWalkingBackwards", false);
        }
        
        else
        {
            anim.SetBool("isRunning", false);
            
        }
    }
}
