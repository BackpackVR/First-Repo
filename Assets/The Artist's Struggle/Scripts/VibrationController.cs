using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VibrationController : MonoBehaviour
{
    public XRBaseController lController, rController;
    public float amplitude = .5f;
    public float duration = .5f;

    public void SendVibrations()
    {
        lController.SendHapticImpulse(amplitude, duration);
        rController.SendHapticImpulse(amplitude, duration);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
