using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeAngryBirdBehaviour : MonoBehaviour
{
    [HideInInspector]
    public bool birdClicked = false;
    bool birdLaunch = false;

    Rigidbody2D myRb;

    private void Awake()
    {
        myRb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 mousePos2D = new Vector2(mousePos.x , mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.tag =="Player" && !birdClicked && !birdLaunch)
                {
                    Debug.Log("Bird CLickeddddddd XD");
                    OnBirdClick();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }

    }

    void OnBirdClick() {
        transform.Rotate(180 , 180 , 0);
        birdClicked = true;
    }

    public void BirdLaunch(float str)
    {
        birdLaunch = true; 
        birdClicked = false;
        transform.parent = null;

        myRb.isKinematic = false; 
        myRb.AddForce(transform.right * (str), ForceMode2D.Impulse);
    }
}
