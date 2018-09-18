using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicMovement : MonoBehaviour {


    public enum Algorithm
    {
        Wander,
        Pursue,
        Evade,
        Path
    }

    public Algorithm algorithm = Algorithm.Wander;

    Vector3 linearVelocity;
    float angularVelocity;
    Vector3 linearAcceleration;
    float angularAcceleration;

	
	// Update is called once per frame
	void Update () {

        transform.Translate(linearVelocity * Time.deltaTime);
        transform.Rotate(0f, 0f, angularVelocity);

        linearVelocity += linearAcceleration * Time.deltaTime;
        angularVelocity += angularAcceleration * Time.deltaTime;
	}
}
