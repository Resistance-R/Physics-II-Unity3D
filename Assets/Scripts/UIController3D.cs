using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController3D : MonoBehaviour
{
    private NetForce3D NF;
    private float TV;
    private float vel;

    public enum InfoType { theory, velocity, vector }
    public InfoType type;

    Text myText;

    void Start()
    {
        myText = GetComponent<Text>();
        NF = FindObjectOfType<NetForce3D>();
    }

    void Update()
    {
        TV = NF.theory;
        vel = NF.myVel;
        UIControl();
    }

    private void UIControl()
    {
        switch (type)
        {
            case InfoType.theory:
                myText.text = ("Theoretical Value: " + TV.ToString());

                break;

            case InfoType.velocity:
                myText.text = ("Velocity: " + vel);

                break;

            case InfoType.vector:
                myText.text = ("Total Vector: " + NF.GetForceVector());

                break;
        }
    }
}
