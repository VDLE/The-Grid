using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Valve.VR;


public static class AxisManager
{
    public static int pressed;
    public static float turn;
}

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        private void FixedUpdate()
        {

            // pass the input to the car!
            
            float h = -AxisManager.turn;//CrossPlatformInputManager.GetAxis("Horizontal");
            if (Mathf.Abs(AxisManager.turn) < .1)
            {
                h = 0;
            }
                float v = AxisManager.pressed;//CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
