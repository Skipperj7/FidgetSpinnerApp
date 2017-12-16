using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinForPCRight : MonoBehaviour {
    public float rightVelocity;
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightVelocity = (rightVelocity + .075f);
            rightSpin();
        }
        else
        {
            StartCoroutine(right(0.0f));
            rightSpin();
        }
        if(rightVelocity <= 0f)
        {
            rightVelocity = 0f;
        }
    }
    private IEnumerator right(float waitTime)
    {
        while (rightVelocity > 0f)
        {
            rightVelocity = (rightVelocity - .05f);
            yield return new WaitForSeconds(1.5f);
        }
    }
    void rightSpin()
    { 
        transform.Rotate(Vector3.back * rightVelocity);
    }
}