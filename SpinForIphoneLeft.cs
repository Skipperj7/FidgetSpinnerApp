using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpinForIphoneLeft : MonoBehaviour {
    public float leftVelocity;
    public Vector2 startPos;
   
    public Vector2 distance;
   
   

    private bool leftActive;
    // Use this for initialization
    void Start () {
				
        StartCoroutine(left(0f));
    }
	
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    startPos = touch.position;
                    
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:

                    distance = touch.position - startPos;
                    if (distance.x + distance.y < startPos.x + startPos.y)
                    {
                        leftVelocity = (leftVelocity + 1f);
                    }
                    else if (distance.x + distance.y > startPos.x + startPos.y)
                    {
                        leftVelocity = (leftVelocity - 1f);
                    }
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:

                    break;
            }

        }
        else
        {
            StartCoroutine(left(0f));
        }
        
        leftSpin();
    }

    private IEnumerator left(float waitTime)
    {
        while (leftActive)
        {
            while (leftVelocity > 0f)
            {
                leftVelocity = (leftVelocity - .01f);
                yield return new WaitForSeconds(.1f);
            }
            while (leftVelocity < 0f)
            {
                leftVelocity = (leftVelocity + .01f);
                yield return new WaitForSeconds(.1f);
            }
        }
    }
    void leftSpin()
    { 
        transform.Rotate(Vector3.forward * leftVelocity);
    }

   
}