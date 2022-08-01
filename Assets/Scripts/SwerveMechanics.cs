using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMechanics : MonoBehaviour
{
    private float lastFingerPosX;
    public float moveX;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            moveX = Input.mousePosition.x - lastFingerPosX;
            lastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            moveX = .0f;
        }
    }
}
