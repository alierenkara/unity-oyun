using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinir : MonoBehaviour {

    public float left = -3.81f;
    public float right = 3.81f;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 currentPosition = transform.position;
        // modify the variable to keep y within minY to maxY
        currentPosition.x =
           Mathf.Clamp(currentPosition.x, left, right);
        // and now set the transform position to our modified vector
        transform.position = currentPosition;

    }
}
