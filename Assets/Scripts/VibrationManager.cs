using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VibrationManager : MonoBehaviour
{
    public SteamVR_Input_Sources controller;
    public SteamVR_Action_Vibration vibration;
    public SteamVR_Action_Boolean trigger;
    public float secStart;
    public float secEnd;
    public float frequency;
    public float strength;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.GetState(controller))
        {
            Debug.Log("Trigger ON");
            vibration.Execute(secStart, secEnd, frequency, strength, controller);
        }
    }
}
