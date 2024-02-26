using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixRotation : MonoBehaviour
{

    public float rotationSpeedPC = 200f;
    public float rotationSpeedAndroid = 50f;

    private void Update()
    {
#if UNITY_EDITOR


        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxisRaw("Mouse X");
            transform.Rotate(transform.position.x, -mouseX * Time.deltaTime * rotationSpeedPC, transform.position.z);

        }
#elif UNITY_ANDROID
                 if (Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Moved)
             {
            float deltaXPosition = Input.GetTouch(0).deltaPosition.x;
            transform.Rotate(transform.position.x, -deltaXPosition * rotationSpeedAndroid * Time.deltaTime,
                transform.position.z);
            }

#endif
    }
}
