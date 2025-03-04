using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveLogic : MonoBehaviour
{
    float hor , vert;
    Animator animator;
    float x ,y;
    [SerializeField]
    float speed;

    Transform tarns;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        tarns = transform;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");

        if (vert > 0 && (Mathf.Abs(hor) < 1))
        {
            animator.SetInteger("Direction" , 1);    
        }
         if ((Mathf.Abs(vert) < 1) && hor > 0)
        {
            animator.SetInteger("Direction" , 2);    
        }
         if (vert < 0 && (Mathf.Abs(hor) < 1))
        {
            animator.SetInteger("Direction" , 3);    
        }
        if ((Mathf.Abs(vert) < 1) && hor < 0)
        {
            animator.SetInteger("Direction" , 4);    
        }
        if (vert == 0 && hor == 0)
        {
            animator.SetInteger("Direction" , 0);
        }
        x += hor * speed * Time.deltaTime;
        y += vert * speed * Time.deltaTime;
        tarns.position = new Vector3(x, y, tarns.position.z);

    }
}
