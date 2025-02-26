using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherBehavioour : MonoBehaviour
{
    public FakeAngryBirdBehaviour bird;

    Vector2 mousePos;
    Vector2 newPos;
    float dist;

    const int MULTIPLIER = 7;
    // Update is called once per frame
    void Update()
    {
        if (bird.birdClicked)
        {
           CalcDirection();

            CalcStrength();
        }

        if (Input.GetMouseButtonDown(0) && bird.birdClicked) {
            Debug.Log("Bird Launchhhhh");
            bird.BirdLaunch(dist * MULTIPLIER);
        }
    }

    private void CalcDirection()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void CalcStrength() {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        newPos = new Vector2(transform.position.x, transform.position.y);

        dist = Vector2.Distance(mousePos, newPos);

        dist = Mathf.Clamp(dist, 0, 4);

        bird.transform.localPosition = new Vector3(dist , 0, 0);
    }
}