using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetForce2D : MonoBehaviour
{
    private float XThrust = 3.0f;
    private float YThrust = 4.0f;
    private Rigidbody myRigid;

    public float theory;
    public float myVel;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        myRigid.AddForce(transform.up * YThrust, ForceMode.Impulse);
        myRigid.AddForce(transform.right * -XThrust, ForceMode.Impulse);
    }


    void Update()
    {
        float velocityMagnitude = myRigid.velocity.magnitude;
        float forceAngle = Mathf.Deg2Rad * 90f;
        float theoreticalValue = Mathf.Sqrt(Mathf.Pow(XThrust, 2) + Mathf.Pow(YThrust, 2) + 2 * XThrust * YThrust * Mathf.Cos(forceAngle));
        Debug.Log("Theoretical Value: " + theoreticalValue);
        Debug.Log("Velocity: " + velocityMagnitude);
        Debug.Log("Total Vector: " + myRigid.velocity);

        theory = theoreticalValue;
        myVel = velocityMagnitude;
    }

    public Vector3 GetForceVector()
    {
        return myRigid.velocity;
    }
}
