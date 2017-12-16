using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinForPCLeft : MonoBehaviour {
    public float leftVelocity;
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftVelocity = (leftVelocity + .075f);
            leftSpin();
        }
        else
        {
            StartCoroutine(left(0.0f));
            leftSpin();
        }
        if(leftVelocity <= 0f)
        {
            leftVelocity = 0f;
        }
    }
    private IEnumerator left(float waitTime)
    {
        while (leftVelocity > 0f)
        {
            leftVelocity = (leftVelocity - .05f);
            yield return new WaitForSeconds(1.5f);
        }
    }
    void leftSpin()
    { 
        transform.Rotate(Vector3.forward * leftVelocity);
    }
}