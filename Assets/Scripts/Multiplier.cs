using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Multiplier : MonoBehaviour
{
    public Transform multiPoint;
    public GameObject BirdEnemyFlapSprite;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(BirdEnemyFlapSprite , multiPoint.position, transform.rotation);
        }
    }
}
