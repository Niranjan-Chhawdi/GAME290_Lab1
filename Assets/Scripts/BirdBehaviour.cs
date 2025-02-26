using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{

    public float inc;
    [SerializeField] float x, y;
    Vector2 vel;
    Vector2 pos;
    public Rigidbody2D rb;
    public ForceMode2D fm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            y += inc;
            Debug.Log("VEL: " + x + "; " + y);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            y -= inc;
            Debug.Log("VEL: " + x + "; " + y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += inc;
            Debug.Log("VEL: " + x + "; " + y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x -= inc;
            Debug.Log("VEL: " + x + "; " + y);
        }

        if (Input.GetKey(KeyCode.R))
        {
            Transform t = GetComponent<Transform>();
            t.position = pos;
            t.rotation = Quaternion.identity;
        }


        if (Input.GetKey(KeyCode.Space))
        {
            vel = new Vector2(x, y);
            rb.AddForce(vel, fm);
        }

    }
}