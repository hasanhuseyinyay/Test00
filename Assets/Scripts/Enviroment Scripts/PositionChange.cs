using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChange : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float targetValue;
    [SerializeField]
    private bool objectgoingLeftSide = false;
   
    void Update()
    {
        ObjectPositionChange();
    }


    private void ObjectPositionChange()
    {
        if (!objectgoingLeftSide)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;

            if (gameObject.transform.position.x > targetValue)
                objectgoingLeftSide = true;
        }
        else
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;

            if (gameObject.transform.position.x < -targetValue)
                objectgoingLeftSide = false;
        }

    }
}
